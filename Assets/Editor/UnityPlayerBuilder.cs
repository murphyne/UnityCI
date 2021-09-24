using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

public static class UnityPlayerBuilder
{
    private static void GenericBuild(BuildPlayerOptions buildPlayerOptions)
    {
        var report = BuildPipeline.BuildPlayer(buildPlayerOptions);
        var summary = report.summary;

        if (summary.result != BuildResult.Succeeded)
        {
            var message = $"While building occured {summary.totalErrors} errors";
            throw new BuildFailedException(message);
        }
    }

    private static void BuildAndroid()
    {
        var argIndex = CommandLineHelpers.GetArgIndex("-customBuildPath");
        var buildPath = CommandLineHelpers.GetArgValue(argIndex + 1);

        var buildPlayerOptions = new BuildPlayerOptions()
        {
            scenes = new[]
            {
                "Assets/Scenes/SampleScene.unity",
            },
            locationPathName = buildPath,
            target = BuildTarget.Android,
            options = BuildOptions.None,
        };

        GenericBuild(buildPlayerOptions);
    }
}
