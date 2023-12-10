using System.Collections.Generic;

namespace Appulate.CodeDiagrams.MassTransit.Consumers.Models;

/// <summary>
/// Event = type which represents T from IConsumer&amp;amp;lt;T&amp;amp;gt;
/// </summary>
public record Event(string Hash, string Name, string Namespace, string Assembly, IEnumerable<Caller> Callers);