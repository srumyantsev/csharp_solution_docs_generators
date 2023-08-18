using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;

namespace Appulate.CodeDiagrams.MassTransit.Consumers;

internal static class ConsumersFinder
{
    private const string AppulateNamespacePrefix = "Appulate";
    private const string MassTransitConsumerInterfaceFullName = "MassTransit.IConsumer`1";

    internal static async Task<IEnumerable<INamedTypeSymbol>> FindAsync(Solution solution)
    {
        INamedTypeSymbol consumerInterface = (await solution.Projects.First().GetCompilationAsync()).GetTypeByMetadataName(MassTransitConsumerInterfaceFullName);
        IEnumerable<INamedTypeSymbol> consumers = await SymbolFinder.FindImplementationsAsync(consumerInterface, solution);
        return consumers.Where(c => c.ToString().StartsWith(AppulateNamespacePrefix) && !c.IsAbstract && !c.ContainingModule.Name.Contains("Tests")).ToList();
    }
}
