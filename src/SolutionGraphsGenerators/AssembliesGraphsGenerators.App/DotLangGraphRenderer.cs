using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AssembliesGraphsGenerators.App {
    internal static class DotLangGraphRenderer {
        internal static void Render(IEnumerable<AssemblyData> assemblies, string[] assembliesIdsToExclude) {
            var graph = new StringBuilder();
            graph.AppendLine(@"digraph AssembliesDependencies {
			label=""Assemblies Dependencies"";
			fontname=""Helvetica"";
			fontsize=""10"";
			node[fontname=""Helvetica"", fontsize=""10"",shape=box];
			edge[arrowhead=""vee"", style=""dashed"", color=""#003388"", fontname=""Helvetica"", fontsize=""8""];");

            var nodes = new StringBuilder();
            var edges = new StringBuilder();
            foreach (AssemblyData assembly in assemblies) {
                if (assembliesIdsToExclude.Contains(assembly.Id)) {
                    continue;
                }

                nodes.AppendLine($"{assembly.Id}[label=\"{assembly.Name};{assembly.TargetFramework}\"];");
                foreach (string referencedAssemblyId in assembly.ReferencedAssemblyIds) {
                    if (assembliesIdsToExclude.Contains(referencedAssemblyId)) {
                        continue;
                    }

                    edges.AppendLine($"{assembly.Id} -> {referencedAssemblyId};");
                }
            }

            graph.Append(nodes);
            graph.Append(edges);
            graph.AppendLine("}");

            File.WriteAllText("result.gv", graph.ToString());
        }
    }
}