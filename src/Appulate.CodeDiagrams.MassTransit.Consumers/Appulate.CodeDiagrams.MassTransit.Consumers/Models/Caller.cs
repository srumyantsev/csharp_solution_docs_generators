namespace Appulate.CodeDiagrams.MassTransit.Consumers.Models;

/// <summary>
/// Caller = method which call constructor of "Event".
/// Important: Caller isn't always methods which actually Publish event.
/// </summary>
public record Caller(string Hash, string Name, string Namespace, string Assembly, string ContainingType, string CallerMethodName);