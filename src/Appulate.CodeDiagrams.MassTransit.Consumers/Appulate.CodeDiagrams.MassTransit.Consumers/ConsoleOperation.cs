using System;

namespace Appulate.CodeDiagrams.MassTransit.Consumers;

internal class ConsoleOperation
{
    private readonly object _operation;
    public ConsoleOperation(string[] args)
    {
        OperationType = args[0] switch
        {
            "find" => ConsoleOperationType.Find,
            "export" => ConsoleOperationType.Export,
            _ => throw new ArgumentOutOfRangeException("args[0]", $"Not expected operation value: {args[0]}"),
        };

        switch (OperationType)
        {
            case ConsoleOperationType.Find:
                _operation = new FindOperation
                {
                    SolutionPath = args[1],
                    SavePath = args[2]
                };
                break;
            case ConsoleOperationType.Export:
                _operation = new ExportOperation
                {
                    LoadPath = args[1],
                    ExportPath = args[2]
                };
                break;
        }
    }

    public ConsoleOperationType OperationType { get; private set; }

    public T GetOperation<T>() => (T)_operation;
}

internal enum ConsoleOperationType
{
    Find,
    Export
}

internal class FindOperation
{
    public string SolutionPath { get; set; }
    public string SavePath { get; set; }
}

internal class ExportOperation
{
    public string LoadPath { get; set; }
    public string ExportPath { get; set; }
}