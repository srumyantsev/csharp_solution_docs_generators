using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;
using System.Text;

namespace Appulate.CodeDiagrams.MassTransit.Consumers;

/// <summary>
/// PlantUml component diagram https://plantuml.com/component-diagram
/// Paste result to https://www.plantuml.com/plantuml/uml and save result SVG
/// </summary>
internal static class ResultPlantUmlComponentsDiagramWriter
{
    internal static async Task WriteAsync(Dictionary<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>> consumersPayloadsPayloadsContructorsCallers, string outputFilePath)
    {
        var packages = new Dictionary<string, List<(string ComponentName, string ComponentColor)>>();
        var relations = new StringBuilder();
        foreach (KeyValuePair<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>> consumersPayloadsPayloadsContructorsCallersItem in consumersPayloadsPayloadsContructorsCallers.OrderBy(i => i.Key.ToString()))
        {
            AddOrAppendToDictionary<(string ComponentName, string ComponentColor)>(packages, consumersPayloadsPayloadsContructorsCallersItem.Key.ContainingModule.ToString(), (consumersPayloadsPayloadsContructorsCallersItem.Key.ToString(), "Purple"));
            foreach (KeyValuePair<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>> payloadPayloadsContructorsCallers in consumersPayloadsPayloadsContructorsCallersItem.Value.OrderBy(i => i.Key.ToString()))
            {
                AddOrAppendToDictionary<(string ComponentName, string ComponentColor)>(packages, payloadPayloadsContructorsCallers.Key.ContainingModule.ToString(), (payloadPayloadsContructorsCallers.Key.ToString(), "Orange"));
                relations.AppendLine($"[{payloadPayloadsContructorsCallers.Key}] --> [{consumersPayloadsPayloadsContructorsCallersItem.Key}]");
                foreach (SymbolCallerInfo payloadsContructorsCaller in payloadPayloadsContructorsCallers.Value.OrderBy(i => i.CallingSymbol.ToString()))
                {
                    AddOrAppendToDictionary<(string ComponentName, string ComponentColor)>(packages, payloadsContructorsCaller.CallingSymbol.ContainingModule.ToString(), (SanitizeCallingSymbol((IMethodSymbol)payloadsContructorsCaller.CallingSymbol), "Blue"));
                    relations.AppendLine($"[{SanitizeCallingSymbol((IMethodSymbol)payloadsContructorsCaller.CallingSymbol)}] --> [{payloadPayloadsContructorsCallers.Key}]");
                }
            }
        }

        var packagesSb = new StringBuilder();
        foreach (KeyValuePair<string, List<(string ComponentName, string ComponentColor)>> package in packages.OrderBy(p => p.Key))
        {
            packagesSb.AppendLine($"package \"{package.Key}\" {{");
            foreach ((string ComponentName, string ComponentColor) component in package.Value.OrderBy(c => c.ComponentName))
            {
                packagesSb.AppendLine($"\t[{component.ComponentName}] #{component.ComponentColor}");
            }            
            packagesSb.AppendLine("}");
        }
        
        string result = @$"
@startuml
'PlantUml component diagram https://plantuml.com/component-diagram
'Themes https://plantuml.com/theme
'Paste result to https://www.plantuml.com/plantuml/uml and save result SVG

!theme bluegray
left to right direction
skinparam componentFontSize 30

package ""Agenda"" {{
        [Action] #Blue
        [Event] #Orange
        [Policy] #Purple
        [Action] --> [Event]
        [Event] --> [Policy]
}}

{string.Join(Environment.NewLine, packagesSb)}

{string.Join(Environment.NewLine, relations)}

@enduml
";
        await File.WriteAllTextAsync($"{outputFilePath}.plantuml", result);
    }

    private static void AddOrAppendToDictionary<T>(Dictionary<string, List<T>> dictionary, string key, T value)
    {
        if (dictionary.ContainsKey(key))
        {
            dictionary[key].Add(value);
        }
        else
        {
            dictionary.Add(key, new List<T> { value });
        }
    }

    private static string SanitizeCallingSymbol(IMethodSymbol methodSymbol)
    {
        return methodSymbol.ToString().Replace('(', '_').Replace(')', '_').Replace(',', '_').Replace('[', '_').Replace(']', '_');
    }
}
