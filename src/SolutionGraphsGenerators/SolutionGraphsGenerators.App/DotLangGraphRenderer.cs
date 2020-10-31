using System.IO;
using System.Text;
using SD.Tools.Algorithmia.Graphs;
using SolutionGraphsGenerators.App.Models;

namespace SolutionGraphsGenerators.App {
    internal static class DotLangGraphRenderer {
        internal static void Render(DirectedGraph<Project, ProjectDependency> graph) {

            var graphAsString = new StringBuilder();
            graphAsString.AppendLine(@"digraph ProjectDependencies {
			label=""Project Dependencies"";
			fontname=""Helvetica"";
			fontsize=""10"";
			node[fontname=""Helvetica"", fontsize=""10"",shape=box];
			edge[arrowhead=""vee"", style=""dashed"", color=""#003388"", fontname=""Helvetica"", fontsize=""8""];");

            foreach (Project project in graph.Vertices) {
                graphAsString.AppendLine($"{project.Id}[label=\"{project.Name}\"];");
            }

            foreach (ProjectDependency dependency in graph.Edges) {
                graphAsString.AppendLine($"{dependency.StartVertex.Id} -> {dependency.EndVertex.Id};");
            }

            graphAsString.AppendLine("}");

            File.WriteAllText("result.gv", graphAsString.ToString());
        }
    }
}