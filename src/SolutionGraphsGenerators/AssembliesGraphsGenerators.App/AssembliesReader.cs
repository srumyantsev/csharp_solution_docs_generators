using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using DotNet.Globbing;

namespace AssembliesGraphsGenerators.App {
    static internal class AssembliesReader {
        internal static IEnumerable<AssemblyData> ReadAssemblies(string assembliesFolderPath, string[] assembliesFileNameFilters, Glob[] referencedAssemblyNameFilters, SearchOption searchOption) {
            foreach (string assemblyFilePath in assembliesFileNameFilters.SelectMany(f => Directory.EnumerateFiles(assembliesFolderPath, f, searchOption))) {
                Assembly assembly = Assembly.LoadFrom(assemblyFilePath);
                assembly.GetReferencedAssemblies();
                string targetFramework =
                    (assembly.GetCustomAttributes(typeof(TargetFrameworkAttribute)).SingleOrDefault() as TargetFrameworkAttribute)?.FrameworkName;

                yield return new AssemblyData(GenerateAssemblyId(assembly.GetName().Name), assembly.GetName().Name, assembly.Location, targetFramework ?? "UNKNOWN",
                    assembly.GetReferencedAssemblies().Where(an => referencedAssemblyNameFilters.Any(g => g.IsMatch(an.Name))).Select(an => GenerateAssemblyId(an.Name)));
            }
        }

        private static string GenerateAssemblyId(string assemblyName) {
            return assemblyName.Replace(".", string.Empty).ToLower();
        }
    }
}