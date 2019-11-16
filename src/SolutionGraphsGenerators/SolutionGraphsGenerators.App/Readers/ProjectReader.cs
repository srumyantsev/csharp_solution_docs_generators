using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace SolutionGraphsGenerators.App.Readers {
	public static class ProjectReader {
		public static IEnumerable<string> GetProjectReferences(string projectPath) {
			var document = XDocument.Load(projectPath);
			if (document.Root == null) { 
				throw new Exception($"Error loading {projectPath}");
			}

			string xmlns = document.Root.Attribute("xmlns")?.Value;

			XName GetXName(string name)
			{
				return string.IsNullOrEmpty(xmlns) ? XName.Get(name) : XName.Get(name, xmlns);
			}

			return document.Root
				.Elements(GetXName("ItemGroup"))
				.Elements(GetXName("ProjectReference"))
				.Select(i => Path.Combine(Path.GetDirectoryName(projectPath),
					Path.GetDirectoryName(i.Attribute("Include").Value))).ToList();
		}
	}
}
