using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;
using System.Text;

namespace Appulate.CodeDiagrams.MassTransit.Consumers;

internal static class ResultTextWriter
{
    internal static async Task WriteAsync(Dictionary<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>> consumersPayloadsPayloadsContructorsCallers, string outputFilePath)
    {
        var sb = new StringBuilder();
        foreach (KeyValuePair<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>> consumersPayloadsPayloadsContructorsCallersItem in consumersPayloadsPayloadsContructorsCallers.OrderBy(i => i.Key.ToString()))
        {
            sb.AppendLine($"{consumersPayloadsPayloadsContructorsCallersItem.Key}");
            foreach (KeyValuePair<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>> payloadPayloadsContructorsCallers in consumersPayloadsPayloadsContructorsCallersItem.Value.OrderBy(i => i.Key.ToString()))
            {
                sb.AppendLine($"\t{payloadPayloadsContructorsCallers.Key}");
                foreach (SymbolCallerInfo payloadsContructorsCaller in payloadPayloadsContructorsCallers.Value.OrderBy(i => i.CallingSymbol.ToString()))
                {
                    sb.AppendLine($"\t\t{payloadsContructorsCaller.CallingSymbol}");
                }
            }
        }
        await File.WriteAllTextAsync(outputFilePath, sb.ToString());
    }
}
