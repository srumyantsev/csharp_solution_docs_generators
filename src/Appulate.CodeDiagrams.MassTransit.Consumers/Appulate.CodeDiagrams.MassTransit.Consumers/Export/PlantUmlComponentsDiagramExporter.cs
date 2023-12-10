using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appulate.CodeDiagrams.MassTransit.Consumers.Models;

namespace Appulate.CodeDiagrams.MassTransit.Consumers.Export;

/// <summary>
/// PlantUml component diagram https://plantuml.com/component-diagram
/// Paste result to https://www.plantuml.com/plantuml/uml and save result SVG
/// </summary>
internal static class PlantUmlComponentsDiagramExporter
{
    internal static async Task ExportAsync(IEnumerable<Consumer> consumers, string outputFilePath)
    {
        //package = project/assembly
        var packages = new Dictionary<string, List<Component>>();
        var relations = new StringBuilder();

        foreach (Consumer consumer in consumers.OrderBy(c => c.Name.ToString()))
        {
            AddOrAppendToDict(packages, consumer.Assembly, new($"{consumer.Name}\\nNamespace: {consumer.Namespace}", consumer.Hash, "Purple"));
            foreach (Event @event in consumer.Events.OrderBy(e => e.Name.ToString()))
            {
                AddOrAppendToDict(packages, @event.Assembly, new($"{@event.Name}\\nNamespace: {@event.Namespace}", @event.Hash, "Orange"));
                relations.AppendLine($"[{@event.Hash}] --> [{consumer.Hash}]");
                foreach (Caller caller in @event.Callers.OrderBy(c => c.Name))
                {
                    AddOrAppendToDict(packages, caller.Assembly, new($"{caller.Name}\\nClass: {caller.Namespace}.{caller.ContainingType}", caller.Hash, "Blue"));
                    relations.AppendLine($"[{caller.Hash}] --> [{@event.Hash}]");
                }
            }
        }

        var result = RenderDiagram(packages, relations);
        await File.WriteAllTextAsync($"{outputFilePath}", result);
    }

    private static string RenderDiagram(Dictionary<string, List<Component>> packages, StringBuilder relations)
    {
        var packagesSb = new StringBuilder();
        foreach (KeyValuePair<string, List<Component>> package in packages.OrderBy(p => p.Key))
        {
            packagesSb.AppendLine($"package \"{package.Key}\" {{");
            foreach (Component component in package.Value.OrderBy(c => c.ComponentName))
            {
                packagesSb.AppendLine($"\t[{component.ComponentName}] as {component.Alias} #{component.ComponentColor}");
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
skinparam ParticipantPadding 20

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
        return result;
    }

    private static void AddOrAppendToDict<T>(Dictionary<string, List<T>> dictionary, string key, T value)
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

    private record Component(string ComponentName, string Alias, string ComponentColor);
}
