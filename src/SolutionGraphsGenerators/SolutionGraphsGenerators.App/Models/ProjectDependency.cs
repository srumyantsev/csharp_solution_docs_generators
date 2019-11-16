using SD.Tools.Algorithmia.Graphs;

namespace SolutionGraphsGenerators.App.Models {
	public class ProjectDependency : DirectedEdge<Project> {
		public ProjectDependency(Project startVertex, Project endVertex) : base(startVertex, endVertex)
		{
		}
	}
}
