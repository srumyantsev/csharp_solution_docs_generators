using System.Collections.Generic;
namespace Appulate.CodeDiagrams.MassTransit.Consumers.Models;

/// <summary>
/// Class which implements IConsumer&amp;amp;lt;T&amp;amp;gt;
/// </summary>
public record Consumer(string Hash, string Name, string Namespace, string Assembly, IEnumerable<Event> Events);