using System.Collections.Generic;
using System.IO;
using System.Linq;
using GenerateAutotestsDocsTool.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GenerateAutotestsDocsTool {
	public static class SourceCodeParser {
		private static readonly string[] MethodNamesToSearch = { "Step", "ExpectedResult" };
		private const string TestAttributeName = "Test";
		private const string PropertyAttributeName = "Property";
		private const string CategoryAttributeName = "Category";
		private const string LinkOnCaseTestPropertyArgumentName = "LinkOnCaseTestProperty";

		public static FileWithTestInfo ParseSourceCodeFile(string sourceCodeFilePath) {
			var code = new StreamReader(sourceCodeFilePath).ReadToEnd();

			SyntaxTree tree = CSharpSyntaxTree.ParseText(code);
			var root = (CompilationUnitSyntax)tree.GetRoot();

			//https://stackoverflow.com/a/15453764
			IEnumerable<MethodDeclarationSyntax> methodWithTestAttributeList = root.DescendantNodes()
																				   .OfType<AttributeSyntax>()
																				   .Where(a => a.Name.ToString() == TestAttributeName)
																				   .Select(a => a.Parent.Parent)
																				   .Cast<MethodDeclarationSyntax>();

			if (!methodWithTestAttributeList.Any()) {
				return null; //there are no test methods inside file
			}

			bool IsTargetMethod(InvocationExpressionSyntax invocationExpressionSyntax) {
				var memberAccessExpressionSyntax =
					invocationExpressionSyntax.Expression as MemberAccessExpressionSyntax;
				if (memberAccessExpressionSyntax == null) {
					return false;
				}

				string methodName = memberAccessExpressionSyntax.Name.ToString();
				return MethodNamesToSearch.Contains(methodName);
			}

			var fileWithTestInfo = new FileWithTestInfo {
				FileName = Path.GetFileName(sourceCodeFilePath)
			};
			foreach (MethodDeclarationSyntax methodDeclarationSyntax in methodWithTestAttributeList) {
				if (methodDeclarationSyntax.Body == null) {
					continue; //skip processing arrow function methods
				}

				var testMethodWorkflow = new TestMethodWorkflow {
					MethodName = methodDeclarationSyntax.Identifier.ToString()
				};

				testMethodWorkflow.TestCaseLinks = methodDeclarationSyntax.DescendantNodes().OfType<AttributeSyntax>()
									   .Where(a => a.Name.ToString() == PropertyAttributeName && (a.ArgumentList.Arguments[0].Expression as IdentifierNameSyntax)?.Identifier.ToString() ==
												   LinkOnCaseTestPropertyArgumentName).Select(pa => pa.ArgumentList.Arguments[1].Expression.ToString()).ToList();

				IEnumerable<string> categoryAttributes = methodDeclarationSyntax.DescendantNodes().OfType<AttributeSyntax>()
																		 .Where(a => a.Name.ToString() == CategoryAttributeName).Select(attrs => attrs.ArgumentList.Arguments[0].Expression.ToString());

				testMethodWorkflow.Categories.AddRange(categoryAttributes);

				IEnumerable<InvocationExpressionSyntax> methodInvocationExpressionSyntaxList = methodDeclarationSyntax.Body.DescendantNodes()
																													  .OfType<InvocationExpressionSyntax>()
																													  .Where(IsTargetMethod);

				if (methodInvocationExpressionSyntaxList.Any()) {
					testMethodWorkflow.Workflows.AddRange(methodInvocationExpressionSyntaxList.Select(mies => mies.Parent.ToString()));
				}

				fileWithTestInfo.TestMethods.Add(testMethodWorkflow);
			}
			return fileWithTestInfo;
		}
	}
}
