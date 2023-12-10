using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appulate.CodeDiagrams.MassTransit.Consumers.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;

namespace Appulate.CodeDiagrams.MassTransit.Consumers.Find;

internal static class EventsWithCallersFinder
{
    internal static async Task<IEnumerable<Consumer>> FindAsync(IEnumerable<INamedTypeSymbol> consumersSymbols, Solution solution)
    {
        var consumers = new List<Consumer>();

        foreach (INamedTypeSymbol consumerSymbol in consumersSymbols)
        {
            var events = new List<Event>();
            foreach (INamedTypeSymbol consumerIConsumerInterfaceWithGenericType in consumerSymbol.AllInterfaces.Where(i => i.IsGenericType))
            {
                ITypeSymbol genericArgumentSymbol = consumerIConsumerInterfaceWithGenericType.TypeArguments[0]; //take T from IConsumer<T>
                events.AddRange(await GetPayloads((INamedTypeSymbol)genericArgumentSymbol, solution));
            }
            consumers.Add(Mapper.MapConsumer(consumerSymbol, events));
        }
        return consumers;
    }

    private static async Task<IEnumerable<Event>> GetPayloads(INamedTypeSymbol genericArgumentSymbol, Solution solution)
    {
        var foundPayloads = new List<INamedTypeSymbol>();
        INamedTypeSymbol currentPayload = genericArgumentSymbol;
        while (currentPayload != null)
        {
            foundPayloads.Add(currentPayload);
            if (currentPayload.TypeKind == TypeKind.Interface)
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

        var events = new List<Event>();
        foreach (var payload in foundPayloads)
        {
            IEnumerable<Task<IEnumerable<SymbolCallerInfo>>> constructorsCallersTasks = payload.InstanceConstructors.Select(ic => SymbolFinder.FindCallersAsync(ic, solution));
            await Task.WhenAll(constructorsCallersTasks);
            List<Caller> callers = constructorsCallersTasks
                .SelectMany(t => t.Result.Where(c => !c.CallingSymbol.ContainingModule.Name.Contains("Tests")))
                .Select(c => Mapper.MapCaller(c.CallingSymbol))
                .ToList();
            events.Add(Mapper.MapEvent(payload, callers));
        }

        return events;
    }
}