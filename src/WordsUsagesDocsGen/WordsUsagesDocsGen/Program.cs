using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;

namespace WordsUsagesDocsGen
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var sln = args[0]; //absolute path to solution file

			//TODO: exclude by projects names

			//TODO: exclude by identifier name

			//TODO: exclude by file path, not just file name
			var ignoredFiles = new[] { new Regex("Reference"), new Regex("\\.Generated") };
			

			//https://stackoverflow.com/a/49886334
			MSBuildLocator.RegisterDefaults();

			var workspace = MSBuildWorkspace.Create();
			var solution = await workspace.OpenSolutionAsync(sln);

			var typeDeclarationInfos = new List<TypeDeclarationInfo>();
			foreach (Project project in solution.Projects)
			{
				foreach (Document document in project.Documents) {
					if (ignoredFiles.Any(i => i.IsMatch(Path.GetFileNameWithoutExtension(document.FilePath)))) {
						continue;
					}

					var documentSyntaxRoot = await document.GetSyntaxRootAsync();
					var typeDeclarationSyntaxCollection = documentSyntaxRoot.DescendantNodes()
						.OfType<TypeDeclarationSyntax>(); //classes, interfaces, structs
					if (typeDeclarationSyntaxCollection != null && typeDeclarationSyntaxCollection.Any()) {
						typeDeclarationInfos.AddRange(typeDeclarationSyntaxCollection.Select(tds => new TypeDeclarationInfo { FilePath = document.FilePath, TypeIdentifier = tds.Identifier.ValueText }));
					}
					var enumDeclarationSyntaxCollection = documentSyntaxRoot.DescendantNodes()
						.OfType<EnumDeclarationSyntax>();
					if (enumDeclarationSyntaxCollection != null && enumDeclarationSyntaxCollection.Any()) {
						typeDeclarationInfos.AddRange(enumDeclarationSyntaxCollection.Select(tds => new TypeDeclarationInfo { FilePath = document.FilePath, TypeIdentifier = tds.Identifier.ValueText }));
					}
				}
			}

			var endingToTypeDeclarationInfoGroups = typeDeclarationInfos.ToLookup(tdi => GetTypeEnding(tdi.TypeIdentifier)).OrderByDescending(i => i.Count());

			string tableStyleClasses = "pure-table pure-table-striped";
			var endingSb = new StringBuilder();
			endingSb.AppendLine($"<table class=\"{tableStyleClasses }\"> ");
			var typesPerEndingSb = new StringBuilder();
			foreach (var endingToTypeDeclarationGroup in endingToTypeDeclarationInfoGroups) {
				var endingId = Guid.NewGuid();
				endingSb.AppendLine($"<tr><td><a href=\"#{endingId}\">{endingToTypeDeclarationGroup.Key}</a></td><td>{endingToTypeDeclarationGroup.Count()}</td></tr>");
				typesPerEndingSb.AppendLine("<div>");
				typesPerEndingSb.AppendLine($"<h1 id=\"{endingId}\">{endingToTypeDeclarationGroup.Key}</h1>");
				typesPerEndingSb.AppendLine($"<table class=\"{tableStyleClasses }\"> ");
				foreach (TypeDeclarationInfo tdi in endingToTypeDeclarationGroup) {
					typesPerEndingSb.AppendLine($"<tr><td>{tdi.TypeIdentifier}</td><td>{tdi.FilePath}</td></tr>");
				}
				typesPerEndingSb.AppendLine("</table>");
				typesPerEndingSb.AppendLine("</div>");
			}
			endingSb.AppendLine("</table>");

			string generalInfo = $"<h3>Types endings</h3><h3>Types: classes, interfaces, structs, enums</h3><h3>Generated: {DateTime.Now.ToString("s")}</h3><h3>Total count of types: {typeDeclarationInfos.Count}</h3><h3>Ignored file masks: {string.Join(";", ignoredFiles.Select(i => i.ToString()))}</h3>";

			string pureCss = "<link rel=\"stylesheet\" href=\"https://unpkg.com/purecss@1.0.1/build/pure-min.css\" integrity=\"sha384-oAOxQR6DkCoMliIh8yFnu25d7Eq/PHS21PClpwjOTeU2jRSq11vu66rf90/cZr47\" crossorigin=\"anonymous\">";
			File.WriteAllText("types-endings.html", $"<html><head><title>Types endings</title>{pureCss}</head><body style=\"padding: 20px;\">{generalInfo}{endingSb}{Environment.NewLine}{typesPerEndingSb}</body></html>");

			string GetTypeEnding(string typeIdentifier) {
				int latestCapitalLetter = -1;
				for (var i = 0; i < typeIdentifier.Length; i++) {
					if (char.IsUpper(typeIdentifier[i])) {
						latestCapitalLetter = i;
					}
				}

				return latestCapitalLetter >= 0 ? typeIdentifier.Substring(latestCapitalLetter) : string.Empty;
			}
		}
	}

	public class TypeDeclarationInfo {
		public Guid Id { get; } = Guid.NewGuid();
		public string FilePath { get; set; }
		public string TypeIdentifier { get; set; }
	}
}