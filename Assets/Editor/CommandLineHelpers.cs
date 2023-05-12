/// <summary>
/// Contains helper methods for getting the command-line arguments
/// passed to the Unity application.
/// </summary>
public static class CommandLineHelpers
{
    /// <summary>
    /// Returns index of an argument with given name.
    /// </summary>
    /// <remarks>
    /// Expects only one occurence of the argument.
    /// </remarks>
    /// <param name="name">Name of the argument.</param>
    /// <returns>
    /// Index of the argument.
    /// If the argument is not found, returns -1.
    /// </returns>
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

    /// <summary>
    /// Returns value of an argument at given index.
    /// </summary>
    /// <param name="index">Index of the argument.</param>
    /// <returns>Value of the argument.</returns>
    public static string GetArgValue(int index)
    {
        var args = System.Environment.GetCommandLineArgs();
        return args[index];
    }
}
