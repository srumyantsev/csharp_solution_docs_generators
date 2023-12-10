using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Appulate.CodeDiagrams.MassTransit.Consumers.Models;

namespace Appulate.CodeDiagrams.MassTransit.Consumers;

public static class SaverLoader
{
    public static async Task SaveAsync(IEnumerable<Consumer> consumers, string targetPath)
    {
        await File.WriteAllTextAsync(targetPath, JsonSerializer.Serialize(consumers, new JsonSerializerOptions(JsonSerializerDefaults.General)
        {
            WriteIndented = true
        }));
    }

    public static async Task<IEnumerable<Consumer>> LoadAsync(string sourcePath)
    {
        string content = await File.ReadAllTextAsync(sourcePath);
        return JsonSerializer.Deserialize<IEnumerable<Consumer>>(content);
    }
}