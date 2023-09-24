

using System.Runtime.CompilerServices;

namespace _0_3TränaTester;

internal class FileService
{
    private static readonly string filePath = @"C:\Nackademin\Practice\PersonList.json";

    public static void SaveToFile (string contentAsJson)
        {
        using var sw = new StreamWriter(filePath);
        sw.WriteLine(contentAsJson);
    }

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }

        return null!;
    }
}
