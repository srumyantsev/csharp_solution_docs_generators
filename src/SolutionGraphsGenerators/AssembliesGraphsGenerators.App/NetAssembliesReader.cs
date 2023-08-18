using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using DotNet.Globbing;
using NLog;

namespace AssembliesGraphsGenerators.App {
#if NETFRAMEWORK
    internal static class NetAssembliesReader {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        internal static IEnumerable<AssemblyData> ReadAssemblies(string assembliesFolderPath, IEnumerable<string> assembliesFileNameFilters, Glob[] referencedAssemblyNameFilters, SearchOption searchOption) {
            foreach (string assemblyFilePath in assembliesFileNameFilters.SelectMany(f => Directory.EnumerateFiles(assembliesFolderPath, f, searchOption))) {
                Assembly assembly;
                try {
                    assembly = Assembly.ReflectionOnlyLoadFrom(assemblyFilePath);
                }
                catch (BadImageFormatException e) {
                    Logger.Warn(e.Message);
                    continue;
                }
                string targetFramework = AssemblyData.UnknownTargetFrameworkConst;
                targetFramework = (assembly.GetCustomAttributes(typeof(TargetFrameworkAttribute)).SingleOrDefault() as TargetFrameworkAttribute)?.FrameworkName ?? AssemblyData.UnknownTargetFrameworkConst;
                var assemblyAttributes = assembly.GetCustomAttributesData();

                yield return new AssemblyData(GenerateAssemblyId(assembly.GetName().Name), assembly.GetName().Name, assembly.Location, targetFramework,
                    assembly.GetReferencedAssemblies().Where(an => referencedAssemblyNameFilters.Any(g => g.IsMatch(an.Name))).Select(an => GenerateAssemblyId(an.Name)));
            }
        }

        private static string GenerateAssemblyId(string assemblyName) {
            return assemblyName.Replace(".", string.Empty).ToLower();
        }
    }
#endif
}