using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace Appulate.CodeDiagrams.MassTransit.Consumers;

/// <summary>
/// https://docs.microsoft.com/en-us/visualstudio/msbuild/updating-an-existing-application?view=vs-2022#use-microsoftbuildlocator    /// 
/// </summary>
internal static class RoslynSetup
{
    internal static async Task<Solution> SetupAsync(string solutionPath)
    {
        //https://docs.microsoft.com/en-us/visualstudio/msbuild/updating-an-existing-application?view=vs-2022#register-instance-before-calling-msbuild
        Init();
        var workspace = MSBuildWorkspace.Create();

        return await workspace.OpenSolutionAsync(solutionPath);
    }

    private static void Init()
    {
        MSBuildLocator.RegisterDefaults();
    }
}
