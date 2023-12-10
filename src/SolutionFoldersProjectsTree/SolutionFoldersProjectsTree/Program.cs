using System.Text;
using System.Text.RegularExpressions;

namespace SolutionFoldersProjectsTree;

internal class Program
{
    static void Main(string[] args)
    {
        string solutionFilePath = @"D:\projects\appulate\Sources\Appulate.sln";

        // An example of a project line looks like this:
        //  Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "ClassLibrary1", "ClassLibrary1\ClassLibrary1.csproj", "{05A5AD00-71B5-4612-AF2F-9EA9121C4111}"
        Regex crackProjectLine = new(
            "^" // Beginning of line
            + "Project\\(\"(?<PROJECTTYPEGUID>.*)\"\\)"
            + "\\s*=\\s*" // Any amount of whitespace plus "=" plus any amount of whitespace
            + "\"(?<PROJECTNAME>.*)\""
            + "\\s*,\\s*" // Any amount of whitespace plus "," plus any amount of whitespace
            + "\"(?<RELATIVEPATH>.*)\""
            + "\\s*,\\s*" // Any amount of whitespace plus "," plus any amount of whitespace
            + "\"(?<PROJECTGUID>.*)\""
            + "$", // End-of-line
            RegexOptions.Compiled
        );

        const string folderProjectTypeGuid = "{2150E333-8FDC-42A3-9474-1A3956D46DE8}";

        string[] solutionContent = File.ReadAllLines(solutionFilePath);

        Dictionary<string, ProjectInfo> projectsAndFolders = solutionContent
            .Select(line => crackProjectLine.Match(line))
            .Where(match => match.Success)
            .Select(
                match => new ProjectInfo(match.Groups["PROJECTTYPEGUID"].Value.Equals(folderProjectTypeGuid),
                    match.Groups["PROJECTNAME"].Value, match.Groups["RELATIVEPATH"].Value,
                    match.Groups["PROJECTGUID"].Value)).ToDictionary(p => p.ProjectGuid);

        int nestedProjectsGlobalSectionStartIndex = Array.FindIndex(solutionContent,
            s => s.Contains("GlobalSection(NestedProjects) = preSolution"));
        int nestedProjectsGlobalSectionEndIndex = Array.FindIndex(solutionContent,
            nestedProjectsGlobalSectionStartIndex, s => s.Contains("EndGlobalSection"));
        string[] nestedProjectsGlobalSection =
            solutionContent[(nestedProjectsGlobalSectionStartIndex + 1)..nestedProjectsGlobalSectionEndIndex];
        // An example of a nested project line looks like this:
        // {1E502267-F38B-4A10-BAC4-97BB0A560E9D} = {0BC2BD72-F414-48E0-9128-0A9F863FFF1A}
        Regex crackNestedProjectLine = new("^(?<CHILDPROJECTTYPEGUID>.*)\\s*=\\s*(?<PARENTPROJECTTYPEGUID>.*)$",
            RegexOptions.Compiled);
        List<NestedProjectInfo> nestedProjects = nestedProjectsGlobalSection
            .Select(line => crackNestedProjectLine.Match(line))
            .Where(match => match.Success)
            .Select(
                match => new NestedProjectInfo(match.Groups["CHILDPROJECTTYPEGUID"].Value.Trim(),
                    match.Groups["PARENTPROJECTTYPEGUID"].Value.Trim())).ToList();

        var parents = nestedProjects.Select(np => np.ParentProjectId);
        var children = nestedProjects.Select(np => np.ChildProjectId);
        var rootsIds = parents.Except(children).ToList();
        // add roots as children without parent
        nestedProjects.AddRange(rootsIds.Select(id => new NestedProjectInfo(id!, null)));

        //ChildProjectId must be unique, because project/folder can have only one parent
        IEnumerable<TreeItem<NestedProjectInfo>> nestedProjectsTree = nestedProjects.GenerateTree(
            np => np.ChildProjectId,
            np => np.ParentProjectId != null ? new[] { np.ParentProjectId } : Array.Empty<string>(),
            null,
            np => projectsAndFolders[np.ChildProjectId].ProjectName);

        var sb = new StringBuilder();
        nestedProjectsTree.Visit((currentNode, _, depth) =>
        {
            var currentProjectOrFolder = projectsAndFolders[currentNode.Item.ChildProjectId];
            if (currentProjectOrFolder.IsFolder)
            {
                sb.AppendLine(
                    $"{new string('\t', depth - 1)}- **{currentProjectOrFolder.ProjectName}** - ");
            }
            else
            {
                sb.AppendLine(
                    $"{new string('\t', depth - 1)}- [{currentProjectOrFolder.ProjectName}](./{currentProjectOrFolder.ProjectName}) - ");
            }
        });
        File.WriteAllText("SOLUTION.MD", sb.ToString());
    }
}

public class NestedProjectInfo
{
    public string ChildProjectId { get; }
    public string? ParentProjectId { get; }

    public NestedProjectInfo(string childProjectId, string? parentProjectId)
    {
        ChildProjectId = childProjectId;
        ParentProjectId = parentProjectId;
    }
}

public class ProjectInfo
{
    public ProjectInfo(bool isFolder, string projectName, string projectRelativePath, string projectGuid)
    {
        IsFolder = isFolder;
        ProjectName = projectName;
        ProjectRelativePath = projectRelativePath;
        ProjectGuid = projectGuid;
    }

    public bool IsFolder { get; }
    public string ProjectName { get; }
    public string ProjectRelativePath { get; }
    public string ProjectGuid { get; }
}