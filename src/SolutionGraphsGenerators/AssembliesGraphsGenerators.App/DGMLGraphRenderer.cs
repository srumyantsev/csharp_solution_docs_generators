using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AssembliesGraphsGenerators.App {
    internal static class DGMLGraphRenderer {
        internal static void Render(IEnumerable<AssemblyData> assemblies, string[] assembliesIdsToExclude, string outputFileName) {
            var nodes = new StringBuilder();
            var edges = new StringBuilder();
            foreach (AssemblyData assembly in assemblies) {
                if (assembliesIdsToExclude.Contains(assembly.Id)) {
                    continue;
                }

                nodes.AppendLine($@"<Node Id=""{assembly.Id}"" Label=""{assembly.Name} ({assembly.TargetFrameworkVersion})"" />");
                foreach (string referencedAssemblyId in assembly.ReferencedAssemblyIds) {
                    if (assembliesIdsToExclude.Contains(referencedAssemblyId)) {
                        continue;
                    }

                    edges.AppendLine($@"<Link Source=""{assembly.Id}"" Target=""{referencedAssemblyId}"" />");
                }
            }
            var graph = new StringBuilder();
            graph.Append($@"<?xml version=""1.0"" encoding=""utf-8""?>
                <DirectedGraph Title=""Assemblies Dependencies"" xmlns=""http://schemas.microsoft.com/vs/2009/dgml"" >
                    <Nodes>
                        {nodes}
                    </Nodes>
                    <Links>
                        {edges}
                    </Links>
                    <Styles>
                        <Style TargetType=""Node"" GroupLabel=""Comment"" ValueLabel=""Has comment"">
                          <Condition Expression = ""HasCategory('Comment')"" />
                          <Setter Property=""Background"" Value=""#FFFFFACD"" />
                          <Setter Property=""Stroke"" Value=""#FFE5C365"" />
                          <Setter Property=""StrokeThickness"" Value=""1"" />
                          <Setter Property=""NodeRadius"" Value=""2"" />
                          <Setter Property=""MaxWidth"" Value=""250"" />
                        </Style>
                      </Styles>
                </DirectedGraph>");

            File.WriteAllText($"{outputFileName}.dgml", graph.ToString());
        }
    }
}