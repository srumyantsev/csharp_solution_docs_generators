//using Microsoft.CodeAnalysis;
//using Microsoft.CodeAnalysis.FindSymbols;
//using System.Text;

//namespace Appulate.CodeDiagrams.MassTransit.Consumers.Export;

//internal static class HtmlExporter
//{
//    internal static async Task ExportAsync(Dictionary<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>> consumersPayloadsPayloadsContructorsCallers, string outputFilePath, string templateFilePath)
//    {
//        var packages = new Dictionary<string, IList<string>>();
//        var relations = new StringBuilder();
//        foreach (KeyValuePair<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>> consumersPayloadsPayloadsContructorsCallersItem in consumersPayloadsPayloadsContructorsCallers.OrderBy(i => i.Key.ToString()))
//        {
//            AddOrAppendToDictionary(packages, consumersPayloadsPayloadsContructorsCallersItem.Key.ContainingModule.ToString(), consumersPayloadsPayloadsContructorsCallersItem.Key.ToString());
//            foreach (KeyValuePair<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>> payloadPayloadsContructorsCallers in consumersPayloadsPayloadsContructorsCallersItem.Value.OrderBy(i => i.Key.ToString()))
//            {
//                AddOrAppendToDictionary(packages, payloadPayloadsContructorsCallers.Key.ContainingModule.ToString(), payloadPayloadsContructorsCallers.Key.ToString());
//                relations.AppendLine($"[{payloadPayloadsContructorsCallers.Key}] --> [{consumersPayloadsPayloadsContructorsCallersItem.Key}]");
//                foreach (SymbolCallerInfo payloadsContructorsCaller in payloadPayloadsContructorsCallers.Value.OrderBy(i => i.CallingSymbol.ToString()))
//                {
//                    AddOrAppendToDictionary(packages, payloadsContructorsCaller.CallingSymbol.ContainingModule.ToString(), SanitizeCallingSymbol((IMethodSymbol)payloadsContructorsCaller.CallingSymbol));
//                    relations.AppendLine($"[{SanitizeCallingSymbol((IMethodSymbol)payloadsContructorsCaller.CallingSymbol)}] --> [{payloadPayloadsContructorsCallers.Key}]");
//                }
//            }
//        }

//        var packagesSb = new StringBuilder();
//        foreach (KeyValuePair<string, IList<string>> package in packages.OrderBy(p => p.Key))
//        {
//            packagesSb.AppendLine($"package \"{package.Key}\" {{");
//            foreach (string component in package.Value.OrderBy(c => c))
//            {
//                packagesSb.AppendLine($"\t[{component}]");
//            }            
//            packagesSb.AppendLine("}");
//        }
        
//        string result = @$"
//@startuml

//{string.Join(Environment.NewLine, packagesSb)}

//{string.Join(Environment.NewLine, relations)}

//@enduml
//";
//        string htmlTemplateContent = await File.ReadAllTextAsync(templateFilePath);
//        string resultContent = htmlTemplateContent.Replace("{{CARDS}}", cardsHtml);
//        await File.WriteAllTextAsync(outputFilePath, resultContent);
//    }

//    private static void AddOrAppendToDictionary(Dictionary<string, IList<string>> dictionary, string key, string value)
//    {
//        if (dictionary.ContainsKey(key))
//        {
//            dictionary[key].Add(value);
//        }
//        else
//        {
//            dictionary.Add(key, new List<string> { value });
//        }
//    }

//    private static string SanitizeCallingSymbol(IMethodSymbol methodSymbol)
//    {
//        return methodSymbol.ToString().Replace('(', '_').Replace(')', '_').Replace(',', '_').Replace('[', '_').Replace(']', '_');
//    }
//}
