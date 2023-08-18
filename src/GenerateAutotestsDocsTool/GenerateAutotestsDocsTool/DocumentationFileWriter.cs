using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using GenerateAutotestsDocsTool.Models;

namespace GenerateAutotestsDocsTool {
    public static class DocumentationFileWriter {
        public static void Write(string targetDocumentationFilePath, List<FileWithTestInfo> fileWithTestInfos) {
            if (!Directory.Exists(Path.GetDirectoryName(targetDocumentationFilePath))) {
                Directory.CreateDirectory(Path.GetDirectoryName(targetDocumentationFilePath));
            }

            var documentationFileContentSb = new StringBuilder();
            documentationFileContentSb.AppendLine($"**Timestamp (UTC):** {DateTime.UtcNow.ToString("O")}");
            documentationFileContentSb.AppendLine();
            foreach (FileWithTestInfo fileWithTestInfo in fileWithTestInfos) {
                documentationFileContentSb.AppendLine($"* File: {fileWithTestInfo.FileName}");
                foreach (TestMethodWorkflow testMethodWorkflow in fileWithTestInfo.TestMethods) {
                    documentationFileContentSb.AppendLine($"\t* Method: {testMethodWorkflow.MethodName}");
                    if (testMethodWorkflow.TestCaseLinks.Count == 0) {
                        documentationFileContentSb.AppendLine("\t\t* TestCaseLink: [UNDEFINED]");
                    }
                    else if (testMethodWorkflow.TestCaseLinks.Count == 1) {
                        documentationFileContentSb.AppendLine($"\t\t* TestCaseLink: {testMethodWorkflow.TestCaseLinks[0]}");
                    }
                    else {
                        documentationFileContentSb.AppendLine("\t\t* TestCaseLinks:");
                        foreach (string testCaseLink in testMethodWorkflow.TestCaseLinks) {
                            documentationFileContentSb.AppendLine($"\t\t\t* {testCaseLink}");
                        }
                    }
                    documentationFileContentSb.AppendLine($"\t\t* Categories: {(testMethodWorkflow.Categories.Any() ? string.Join(", ", testMethodWorkflow.Categories) : "[UNDEFINED]")}");
                    foreach (string workflow in testMethodWorkflow.Workflows) {
                        documentationFileContentSb.AppendLine($"\t\t\t* {workflow}");
                    }
                }
            }

            File.WriteAllText(targetDocumentationFilePath, documentationFileContentSb.ToString());
        }
    }
}
