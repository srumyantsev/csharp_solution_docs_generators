using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DotNet.Globbing;
using Microsoft.Extensions.Configuration;
using NLog;

namespace AssembliesGraphsGenerators.App {
    class Program {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static int Main(string[] args) {
            try {
                Settings settings = InitAndReadSettings(args);
                MainImpl(settings);
            }
            catch (Exception ex) {
                Logger.Error(ex);
                return ex.HResult;
            }

            return 0;
        }

        static void MainImpl(Settings settings) {
            IEnumerable<AssemblyData> assemblies;
#if NETFRAMEWORK
            assemblies = NetAssembliesReader.ReadAssemblies(settings.AssembliesFolderPath,
                settings.AssembliesFileNameFilters, settings.ReferencedAssemblyNameFiltersGlobs, settings.AssembliesFolderPathSearchOption);
#else
            assemblies = NetcoreAssembliesReader.ReadAssemblies(settings.AssembliesFolderPath,
                settings.AssembliesFileNameFilters, settings.ReferencedAssemblyNameFiltersGlobs, settings.AssembliesFolderPathSearchOption);
#endif

            //TODO: next line is hardcode for particular use case. Make generic implementation via configuration/parameters
            //string[] assembliesIdsToExclude = assemblies.Where(a => a.IsNetStandardFramework).Select(a => a.Id).ToArray();
            string[] assembliesIdsToExclude = Array.Empty<string>();

            TxtGraphRenderer.Render(assemblies, assembliesIdsToExclude, settings.OutputFileName);
            DotLangGraphRenderer.Render(assemblies, assembliesIdsToExclude, settings.OutputFileName);
            DGMLGraphRenderer.Render(assemblies, assembliesIdsToExclude, settings.OutputFileName);
        }

        static Settings InitAndReadSettings(string[] args) {
            Logger.Debug($"Config: {string.Join(Environment.NewLine, args)}");
            var builder = new ConfigurationBuilder()
                .AddCommandLine(args);
            IConfigurationRoot config = builder.Build();
            var settings = new Settings();
            config.Bind(settings);
            return settings;
        }

        class Settings {
            /// <summary>
            /// Example D:\projects\ProjectName\bin
            /// </summary>
            public string AssembliesFolderPath { get; set; }
            /// <summary>
            /// File search globs. example "CompanyPrefix*.dll", "CompanyPrefix*.exe"
            /// </summary>
            public List<string> AssembliesFileNameFilters { get; set; }
            /// <summary>
            /// File search globs. example "CompanyPrefix*"
            /// </summary>
            public List<string> ReferencedAssemblyNameFilters { get; set; }
            public Glob[] ReferencedAssemblyNameFiltersGlobs => ReferencedAssemblyNameFilters.Select(f => Glob.Parse(f)).ToArray();
            /// <summary>
            /// Output file name without extension
            /// </summary>
            public string OutputFileName { get; set; }
            public SearchOption AssembliesFolderPathSearchOption { get; set; } = SearchOption.TopDirectoryOnly; //TODO, take from configuration/parameters
            public List<string> AssembliesToExclude { get; set; } //TODO: implement
        }
    }
}
