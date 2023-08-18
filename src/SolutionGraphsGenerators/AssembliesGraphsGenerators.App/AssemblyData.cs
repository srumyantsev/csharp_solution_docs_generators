using System;
using System.Collections.Generic;
using System.Linq;

namespace AssembliesGraphsGenerators.App {
    internal class AssemblyData {
        internal const string UnknownTargetFrameworkConst = "UNKNOWN";
        internal string Id { get; }
        internal string Name { get; }
        internal string Location { get; }
        internal string TargetFramework { get; }
        internal string TargetFrameworkVersion =>
            TargetFramework == UnknownTargetFrameworkConst ? TargetFramework : TargetFramework.Substring(TargetFramework.Length - 3, 3);
        internal bool IsNetStandardFramework => TargetFramework.StartsWith(".NETStandard", StringComparison.InvariantCultureIgnoreCase);
        internal IReadOnlyCollection<string> ReferencedAssemblyIds { get; }

        internal AssemblyData(string id, string name, string location, string targetFramework, IEnumerable<string> referencedAssemblyIds) {
            Id = id;
            Name = name;
            Location = location;
            TargetFramework = targetFramework;
            ReferencedAssemblyIds = referencedAssemblyIds.ToArray();
        }
    }
}