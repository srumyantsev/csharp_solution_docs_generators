using SD.Tools.Algorithmia.Graphs;

namespace SolutionGraphsGenerators.App.Models {
    internal class ProjectDependency : DirectedEdge<Project> {
        internal ProjectDependency(Project startVertex, Project endVertex) : base(startVertex, endVertex)
		{
		}
	}
}
