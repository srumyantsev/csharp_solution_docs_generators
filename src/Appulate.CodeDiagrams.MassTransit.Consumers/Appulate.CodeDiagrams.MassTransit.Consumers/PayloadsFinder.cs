using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;

namespace Appulate.CodeDiagrams.MassTransit.Consumers;

internal static class PayloadsFinder
{
    internal static async Task<Dictionary<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>>> FindAsync(IEnumerable<INamedTypeSymbol> consumers, Solution solution)
    {
        var dict = new Dictionary<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>>(SymbolEqualityComparer.Default);

        foreach (INamedTypeSymbol? consumer in consumers)
        {
            ITypeSymbol genericArgumentSymbol = consumer.AllInterfaces[0].TypeArguments[0]; //assume that consumer is class inherited only from MassTransit.Consumer<TMessage>, take generic type
            dict.Add(consumer, await GetPayloads((INamedTypeSymbol)genericArgumentSymbol, solution));
        }
        return dict;
    }

    private static async Task<Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>> GetPayloads(INamedTypeSymbol originalPayload, Solution solution)
    {
        var dict = new Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>(SymbolEqualityComparer.Default);
        var foundPayloads = new List<INamedTypeSymbol>();
        INamedTypeSymbol currentPayload = originalPayload;
        while (currentPayload != null)
        {
            foundPayloads.Add(currentPayload);
            if (originalPayload.TypeKind == TypeKind.Interface)
            {
                foundPayloads.AddRange(await SymbolFinder.FindImplementationsAsync(currentPayload, solution));
            }
            else
            {
                foundPayloads.AddRange(await SymbolFinder.FindDerivedClassesAsync(currentPayload, solution));
            }

            if (currentPayload.IsGenericType)
            {
                currentPayload = currentPayload.TypeArguments[0] as INamedTypeSymbol; //assume that current type is generic type with single parameter only, others not supported
            }
            else
            {
                currentPayload = null;
            }
        }

        foreach (var payload in foundPayloads)
        {
            IEnumerable<Task<IEnumerable<SymbolCallerInfo>>> constructorsCallersTasks = payload.InstanceConstructors.Select(ic => SymbolFinder.FindCallersAsync(ic, solution));
            await Task.WhenAll(constructorsCallersTasks);
            dict.Add(payload, constructorsCallersTasks.SelectMany(t => t.Result.Where(c => !c.CallingSymbol.ContainingModule.Name.Contains("Tests"))).ToList());
        }

        return dict;
    }
}