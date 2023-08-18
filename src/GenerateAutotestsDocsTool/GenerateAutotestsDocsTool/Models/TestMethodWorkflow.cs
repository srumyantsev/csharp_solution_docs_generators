using System.Collections.Generic;

namespace GenerateAutotestsDocsTool.Models {
	public class TestMethodWorkflow {
		public string MethodName { get; set; }
		public List<string> TestCaseLinks { get; set; }
		public List<string> Categories { get; set; } = new List<string>();

		public List<string> Workflows { get; set; } = new List<string>();
	}
}