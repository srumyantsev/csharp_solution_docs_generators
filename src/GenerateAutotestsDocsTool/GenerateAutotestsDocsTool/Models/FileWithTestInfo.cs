using System.Collections.Generic;
using System.Linq;

namespace GenerateAutotestsDocsTool.Models {
	public class FileWithTestInfo {
		public string FileName { get; set; }
		public List<TestMethodWorkflow> TestMethods { get; set; } = new List<TestMethodWorkflow>();

		public override string ToString() {
			return (FileName ?? "[UNDEFINED]") + " Methods: " + (TestMethods != null && TestMethods.Any() ? string.Join(", ", TestMethods.Select(tm => tm.MethodName)) : "[UNDEFINED]");
		}
	}
}