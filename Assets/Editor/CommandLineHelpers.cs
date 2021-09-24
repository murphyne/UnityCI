public static class CommandLineHelpers
{
    public static int GetArgIndex(string name)
    {
        var args = System.Environment.GetCommandLineArgs();
        for (var index = 0; index < args.Length; index++)
        {
            if (args[index] == name)
            {
                return index;
            }
        }
        return -1;
    }

    public static string GetArgValue(int index)
    {
        var args = System.Environment.GetCommandLineArgs();
        return args[index];
    }
}
