namespace SolutionGraphsGenerators.App.Models {
	public sealed class Project {
        public Project(string id, string name, string path) {
            Id = id;
            Name = name;
            Path = path;
        }

        public string Id { get; }
		public string Name { get; }
		public string Path { get; }

        public override string ToString() {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
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
	}
}
