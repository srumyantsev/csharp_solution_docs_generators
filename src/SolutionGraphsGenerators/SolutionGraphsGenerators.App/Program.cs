using System;
using System.IO;
using System.Text;
using SD.Tools.Algorithmia.Graphs;
using SolutionGraphsGenerators.App.Models;
using SolutionGraphsGenerators.App.Readers;

namespace SolutionGraphsGenerators.App {
	class Program {
		static void Main(string[] args) {
			if (args.Length == 0)
			{
				Console.WriteLine("Use C# solution full file path as first parameter");
			}

			string solutionFilePath = args[0];
			var graph = SolutionReader.Parse(solutionFilePath);

            DotLangGraphRenderer.Render(graph);
        }
    }
}
