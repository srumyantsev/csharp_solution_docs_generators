using System;
using System.IO;
using System.Text;
using SolutionGraphsGenerators.App.Models;
using SolutionGraphsGenerators.App.Readers;

namespace SolutionGraphsGenerators.App {
	class Program {
		static void Main(string[] args) {
			if (args.Length == 0)
			{
				Console.WriteLine("Use C# solution full file path as first parameter");
			}
			
			Console.WriteLine("Start");
			string solutionFilePath = args[0];
			var graph = SolutionReader.Parse(solutionFilePath);

			var graphAsString = new StringBuilder();
			graphAsString.AppendLine(@"digraph ProjectDependencies {
			label=""Project Dependencies"";
			fontname=""Helvetica"";
			fontsize=""10"";
			node[fontname=""Helvetica"", fontsize=""10"",shape=box];
			edge[arrowhead=""vee"", style=""dashed"", color=""#003388"", fontname=""Helvetica"", fontsize=""8""];");

			foreach (Project project in graph.Vertices)
			{
				graphAsString.AppendLine($"{project.Id}[label=\"{project.Name}\"];");
			}

			foreach (ProjectDependency dependency in graph.Edges) {
				graphAsString.AppendLine($"{dependency.StartVertex.Id} -> {dependency.EndVertex.Id};");
			}

			graphAsString.AppendLine("}");

			File.WriteAllText("result.gv", graphAsString.ToString());

			Console.WriteLine("Done");
		}
	}
}
