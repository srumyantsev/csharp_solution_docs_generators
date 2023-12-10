using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appulate.CodeDiagrams.MassTransit.Consumers.Models;

namespace Appulate.CodeDiagrams.MassTransit.Consumers.Export;

internal static class TextExporter
{
    internal static async Task ExportAsync(IEnumerable<Consumer> consumers, string outputFilePath)
    {
        var sb = new StringBuilder();
        foreach (Consumer consumer in consumers.OrderBy(c => c.Name.ToString()))
        {
            sb.AppendLine($"{consumer.Name}");
            foreach (Event @event in consumer.Events.OrderBy(e => e.Name.ToString()))
            {
                sb.AppendLine($"\t{@event.Name}");
                foreach (Caller caller in @event.Callers.OrderBy(c => c.Name.ToString()))
                {
                    sb.AppendLine($"\t\t{caller.Name}");
                }
            }
        }
        await File.WriteAllTextAsync(outputFilePath, sb.ToString());
    }
}
