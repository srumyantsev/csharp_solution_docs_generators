using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GenerateAutotestsDocsTool.Models;

namespace GenerateAutotestsDocsTool {
	class Program {
		static void Main(string[] args) {
			if (args == null || args.Length == 0) {
				throw new ArgumentException("No parameters");
			}

			if (!Directory.Exists(args[0])) {
				throw new ArgumentException("First parameter isn't existing folder. Expected path to folder with tests (*.cs files)");
			}
			string folderWithTests = args[0];

			if (args.Length == 1) {
				throw new ArgumentException("Second parameter isn't set. Expected target documentation file path");
			}
			string targetDocumentationFilePath = args[1];

			string categoryNameContainsFilter = args.ElementAtOrDefault(2); //optional parameter

			var fileWithTestInfos = new List<FileWithTestInfo>();
			foreach (string csFilePath in Directory.EnumerateFiles(folderWithTests, "*.cs", SearchOption.AllDirectories)) {
				FileWithTestInfo fileWithTestInfo = SourceCodeParser.ParseSourceCodeFile(csFilePath);
				if (fileWithTestInfo != null) {
					fileWithTestInfos.Add(fileWithTestInfo);
				}
			}

			fileWithTestInfos.Sort((a, b) => string.Compare(a.FileName, b.FileName, StringComparison.InvariantCultureIgnoreCase));
			fileWithTestInfos.ForEach(fwti => fwti.TestMethods.Sort((a, b) => string.Compare(a.MethodName, b.MethodName, StringComparison.InvariantCultureIgnoreCase)));

			//filter out records which have no categories or do not contain at least one category which contains categoryNameContainsFilter
			if (!string.IsNullOrEmpty(categoryNameContainsFilter)) {
				fileWithTestInfos.ForEach(fwti => fwti.TestMethods.RemoveAll(tmw => !tmw.Categories.Exists(c => c.Contains(categoryNameContainsFilter))));
				fileWithTestInfos.RemoveAll(fwti => !fwti.TestMethods.Any() || fwti.TestMethods.Exists(tmw => !tmw.Categories.Any()));
			}

			DocumentationFileWriter.Write(targetDocumentationFilePath, fileWithTestInfos);
		}
	}
}
