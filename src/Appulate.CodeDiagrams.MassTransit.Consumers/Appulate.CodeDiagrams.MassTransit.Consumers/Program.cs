using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Appulate.CodeDiagrams.MassTransit.Consumers.Export;
using Appulate.CodeDiagrams.MassTransit.Consumers.Find;
using Appulate.CodeDiagrams.MassTransit.Consumers.Models;

namespace Appulate.CodeDiagrams.MassTransit.Consumers;

public static class Program
{
    public static async Task Main(params string[] args)
    {
        var operation = new ConsoleOperation(args);

        switch (operation.OperationType)
        {
            case ConsoleOperationType.Find:
                FindOperation findOperation = operation.GetOperation<FindOperation>();
                //find
                IEnumerable<Consumer> consumersToSave = await Finder.FindAsync(findOperation.SolutionPath);
                //save
                await SaverLoader.SaveAsync(consumersToSave, findOperation.SavePath);
                break;
            case ConsoleOperationType.Export:
                ExportOperation exportOperation = operation.GetOperation<ExportOperation>();
                //load
                IEnumerable<Consumer> consumersToExport = await SaverLoader.LoadAsync(exportOperation.LoadPath);
                //export
                await TextExporter.ExportAsync(consumersToExport, $"{exportOperation.ExportPath}.txt");
                await PlantUmlComponentsDiagramExporter.ExportAsync(consumersToExport, $"{exportOperation.ExportPath}.plantuml");
                //await ResultHtmlExporter.ExportAsync(consumers, "result.html", "template.html");
                break;
        }
    }
}
