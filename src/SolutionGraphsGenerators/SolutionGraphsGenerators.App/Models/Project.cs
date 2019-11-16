using System;
using System.IO;

namespace SolutionGraphsGenerators.App.Models {
	public sealed class Project {
		public Project(string nameOrPath)
		{
			Id = GetId(nameOrPath);
			Name = GetName(nameOrPath);
		}

		public string Id { get; }
		public string Name { get; }

		public override string ToString()
		{
			return Name;
		}

		private bool Equals(Project other)
		{
			return string.Equals(Id, other.Id);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Project) obj);
		}

		public override int GetHashCode()
		{
			return (Id != null ? Id.GetHashCode() : 0);
		}

		public static bool operator ==(Project left, Project right)
		{
			return Equals(left, right);
		}

		public static bool operator !=(Project left, Project right)
		{
			return !Equals(left, right);
		}

		public static string GetId(string assemblyName)
		{
			return GetName(assemblyName)
				.Replace(".", string.Empty);
		}

		public static string GetName(string assemblyName) {
			return Path.GetFileName(assemblyName)
				.Replace(".csproj", String.Empty)
				.Replace(".dll", String.Empty);
		}
	}

	//public enum ProjectType
	//{
	//	Library,
	//	Application,
	//	WebApplication
	//}
}
