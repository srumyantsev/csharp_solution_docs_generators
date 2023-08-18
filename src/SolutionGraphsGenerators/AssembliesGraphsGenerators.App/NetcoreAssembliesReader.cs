using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using DotNet.Globbing;
using NLog;

namespace AssembliesGraphsGenerators.App {
    internal static class NetcoreAssembliesReader {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        internal static IEnumerable<AssemblyData> ReadAssemblies(string assembliesFolderPath, IEnumerable<string> assembliesFileNameFilters, Glob[] referencedAssemblyNameFilters, SearchOption searchOption) {
            foreach (string assemblyFilePath in assembliesFileNameFilters.SelectMany(f => Directory.EnumerateFiles(assembliesFolderPath, f, searchOption))) {
                AssemblyData assemblyData;
                try {
                    var resolver = new PathAssemblyResolver(new List<string>(Directory.GetFiles(RuntimeEnvironment.GetRuntimeDirectory(), "*.dll"))
                    {
                        assemblyFilePath
                    });

                    using (var metadataContext = new MetadataLoadContext(resolver)) {
                        Assembly assembly = metadataContext.LoadFromAssemblyPath(assemblyFilePath);
                        Debug.WriteLine(assembly.FullName);
                        var assemblyAttributes = assembly.GetCustomAttributesData();
                        string targetFramework = AssemblyData.UnknownTargetFrameworkConst;
                        string assemblyName = assembly.GetName().Name;
                        foreach (var customAttributeData in assemblyAttributes)
                        {
                            try
                            {
                                if (customAttributeData.AttributeType.FullName == typeof(TargetFrameworkAttribute).FullName) {
                                    targetFramework = customAttributeData.ConstructorArguments.First().Value as string;
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Logger.Trace(ex.Message);
                            }
                        }
                        assemblyData = new AssemblyData(GenerateAssemblyId(assembly.GetName().Name), assembly.GetName().Name, assembly.Location, targetFramework,
                            assembly.GetReferencedAssemblies().Where(an => referencedAssemblyNameFilters.Any(g => g.IsMatch(an.Name))).Select(an => GenerateAssemblyId(an.Name)));
                    }
                    
                }
                catch (BadImageFormatException e) {
                    Logger.Warn(e.Message);
                    continue;
                }

                yield return assemblyData;
            }
        }

        private static string GenerateAssemblyId(string assemblyName) {
            return assemblyName.Replace(".", string.Empty).ToLower();
        }

        //private static string GetLatestDotnetRuntimePath() {
        //    // Start the child process.
        //    var p = new Process();
        //    // Redirect the output stream of the child process.
        //    p.StartInfo.UseShellExecute = false;
        //    p.StartInfo.RedirectStandardOutput = true;
        //    p.StartInfo.FileName = "dotnet";
        //    p.StartInfo.Arguments = "--list-runtimes";
        //    p.Start();
        //    // Do not wait for the child process to exit before
        //    // reading to the end of its redirected stream.
        //    // p.WaitForExit();
        //    // Read the output stream first and then wait.
        //    string output = p.StandardOutput.ReadToEnd();
        //    p.WaitForExit();
        //    string[] dotnetRuntimePathString = output.Split(new []
        //        {
        //            Environment.NewLine
        //        },
        //        StringSplitOptions.None).LastOrDefault(l => l.StartsWith("Microsoft.AspNetCore.App"))?.Split('[', ']');
        //    if (dotnetRuntimePathString == null || dotnetRuntimePathString.Length < 2) {
        //        throw new Exception("Can't locate dotnet runtime path");
        //    }
            
        //    string dotnetRuntimePath = Path.Combine(dotnetRuntimePathString[1], dotnetRuntimePathString[0].Split(' ')[1]);
        //    if (string.IsNullOrEmpty(dotnetRuntimePath)) {
        //        throw new Exception("Can't locate dotnet runtime path");
        //    }
        //    return dotnetRuntimePath;
        //}
    }
}