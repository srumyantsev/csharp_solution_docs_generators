// See https://aka.ms/new-console-template for more information
using Appulate.CodeDiagrams.MassTransit.Consumers;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;

//setup
Solution solution = await RoslynSetup.SetupAsync("D:\\Projects\\appulate\\Sources\\Appulate.sln");

//parse
IEnumerable<INamedTypeSymbol> consumers = await ConsumersFinder.FindAsync(solution);
Dictionary<INamedTypeSymbol, Dictionary<INamedTypeSymbol, IEnumerable<SymbolCallerInfo>>> consumersPayloadsPayloadsContructorsCallers = await PayloadsFinder.FindAsync(consumers, solution);

//print
await ResultTextWriter.WriteAsync(consumersPayloadsPayloadsContructorsCallers, "MassTransit events.txt");
await ResultPlantUmlComponentsDiagramWriter.WriteAsync(consumersPayloadsPayloadsContructorsCallers, "MassTransit events");
//await ResultHtmlWriter.WriteAsync(consumersPayloadsPayloadsContructorsCallers, "result.html", "template.html");