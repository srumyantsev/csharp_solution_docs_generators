using System.Collections.Generic;
using System.IO;
using System.Linq;
using SolutionGraphsGenerators.App.Models;
using SD.Tools.Algorithmia.Graphs;

namespace SolutionGraphsGenerators.App.Readers {
	public static class SolutionReader {
		public static DirectedGraph<Project, ProjectDependency> Parse(string solutionFilePath)
		{
			Dictionary<Project, IEnumerable<string>> projectsWithReferences = new Dictionary<Project, IEnumerable<string>>();

			foreach (string projectFilePath in Directory.EnumerateFiles(Path.GetDirectoryName(solutionFilePath), "*.csproj", SearchOption.AllDirectories))
			{
				projectsWithReferences.Add(new Project(GetProjectId(projectFilePath), GetProjectName(projectFilePath), projectFilePath), ProjectReader.GetProjectReferences(projectFilePath));
			}

			var graph = new DirectedGraph<Project, ProjectDependency>();

			Dictionary<string, Project> projects = projectsWithReferences.Keys.ToDictionary(p => p.Id, p => p);
			foreach (KeyValuePair<Project, IEnumerable<string>> projectsWithReference in projectsWithReferences)
			{
				graph.Add(projectsWithReference.Key);

				foreach (string projectReference in projectsWithReference.Value)
				{
					graph.Add(new ProjectDependency(projectsWithReference.Key, projects[GetProjectId(projectReference)]));
				}
			}

			return graph;
		}

        private static string GetProjectId(string projectFullPath) {
            return GetProjectName(projectFullPath)
                .Replace(".", string.Empty).ToLower();
        }

        private static string GetProjectName(string projectFullPath) {
            return Path.GetFileName(projectFullPath)
                .Replace(".csproj", string.Empty)
                .Replace(".dll", string.Empty);
        }
	}
}
