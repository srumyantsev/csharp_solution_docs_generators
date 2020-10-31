using System.Collections.Generic;
using System.Linq;

namespace AssembliesGraphsGenerators.App {
    internal class AssemblyData {
        internal string Id { get; }
        internal string Name { get; }
        internal string Location { get; }
        internal string TargetFramework { get; }
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