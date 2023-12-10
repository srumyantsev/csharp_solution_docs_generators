using System;
using System.Collections.Generic;
using System.IO.Hashing;
using System.Text;
using Appulate.CodeDiagrams.MassTransit.Consumers.Models;
using Microsoft.CodeAnalysis;

namespace Appulate.CodeDiagrams.MassTransit.Consumers.Find;

internal class Mapper
{
    public static Consumer MapConsumer(INamedTypeSymbol symbol, IEnumerable<Event> events)
    {
        string assembly = symbol.ContainingAssembly.Name;
        string @namespace = symbol.ContainingNamespace.ToDisplayString();
        string hash = GetHash($"{assembly}_{@namespace}_{symbol.ToDisplayString()}"); ;
        return new Consumer(
            hash,
            symbol.Name,
            @namespace,
            assembly,
            events
        );
    }

    public static Event MapEvent(ISymbol symbol, IEnumerable<Caller> callers)
    {
        string assembly = symbol.ContainingAssembly.Name;
        string @namespace = symbol.ContainingNamespace.ToDisplayString();
        string hash = GetHash($"{assembly}_{@namespace}_{symbol.ToDisplayString()}");
        return new Event(
            hash,
            symbol.Name,
            @namespace,
            assembly,
            callers);
    }

    public static Caller MapCaller(ISymbol symbol)
    {
        string assembly = symbol.ContainingAssembly.Name;
        string @namespace = symbol.ContainingNamespace.ToDisplayString();
        string containingType = symbol.ContainingType.Name;
        string hash = GetHash($"{assembly}_{@namespace}_{containingType}_{symbol.ToDisplayString()}");
        return new Caller(
            hash,
            symbol.Name,
            @namespace,
            assembly,
            containingType,
            symbol.Name + "_" + hash
        );
    }

    private static string GetHash(string message)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(message);
        byte[] hash = Crc64.Hash(bytes);
        return Convert.ToHexString(hash);
    }
}