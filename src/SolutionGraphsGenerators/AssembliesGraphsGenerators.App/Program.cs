using System.Collections.Generic;
using System.IO;
using System.Linq;
using DotNet.Globbing;

namespace AssembliesGraphsGenerators.App {
    class Program {
        static void Main(string[] args) {
            string assembliesFolderPath = args[0]; //example D:\projects\ProjectName\bin
            string[] assembliesFileNameFilters = args[1].Split(','); //Comma separated list. File search globs. example "CompanyPrefix*.dll", "CompanyPrefix*.exe"
            Glob[] referencedAssemblyNameFilters = args[2].Split(',').Select(f => Glob.Parse(f)).ToArray(); //Comma separated list. File search globs. example "CompanyPrefix*"
            SearchOption searchOption = SearchOption.TopDirectoryOnly; //TODO, take from configuration/parameters

            IEnumerable<AssemblyData> assemblies = AssembliesReader.ReadAssemblies(assembliesFolderPath, assembliesFileNameFilters, referencedAssemblyNameFilters, searchOption);
            //TODO: next line is hardcode for particular use case. Make generic implementation via configuration/parameters
            string[] assembliesIdsToExclude = assemblies.Where(a => a.TargetFramework.EndsWith("2.0")).Select(a => a.Id).ToArray();

            DotLangGraphRenderer.Render(assemblies, assembliesIdsToExclude);
            DGMLGraphRenderer.Render(assemblies, assembliesIdsToExclude);
        }
    }
}
