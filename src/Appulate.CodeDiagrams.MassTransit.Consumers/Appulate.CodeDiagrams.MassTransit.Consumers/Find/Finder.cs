using System.Collections.Generic;
using System.Threading.Tasks;
using Appulate.CodeDiagrams.MassTransit.Consumers.Models;
using Microsoft.CodeAnalysis;

namespace Appulate.CodeDiagrams.MassTransit.Consumers.Find;

public static class Finder
{
    public static async Task<IEnumerable<Consumer>> FindAsync(string solutionPath)
    {
        //setup
        Solution solution = await RoslynSetup.SetupAsync(solutionPath);

        //parse
        IEnumerable<INamedTypeSymbol> consumersSymbols = await ConsumersFinder.FindAsync(solution);
        return await EventsWithCallersFinder.FindAsync(consumersSymbols, solution);
    }
}