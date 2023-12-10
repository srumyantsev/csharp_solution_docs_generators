using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;

namespace Appulate.CodeDiagrams.MassTransit.Consumers.Find;

internal static class ConsumersFinder
{
    private const string AppulateNamespacePrefix = "Appulate";
    private const string MassTransitConsumerInterfaceFullName = "MassTransit.IConsumer`1";

    internal static async Task<IEnumerable<INamedTypeSymbol>> FindAsync(Solution solution)
    {
        INamedTypeSymbol? consumerInterface = null;
        foreach (Project project in solution.Projects)
        {
            Compilation projectCompilation = await project.GetCompilationAsync();
            consumerInterface = projectCompilation.GetTypeByMetadataName(MassTransitConsumerInterfaceFullName);
            if (consumerInterface != null)
            {
                break;
            }
        }

        if (consumerInterface == null)
        {
            throw new NullReferenceException($"Can't find {MassTransitConsumerInterfaceFullName} symbol");
        }

        IEnumerable<INamedTypeSymbol> consumers = await SymbolFinder.FindImplementationsAsync(consumerInterface, solution);
        return consumers
            .Where(c => c.ToString().StartsWith(AppulateNamespacePrefix) && !c.IsAbstract && !c.ContainingModule.Name.Contains("Tests"))
            .ToList();
    }
}
