using System.Text;

namespace advent_of_code;

public class FileHandler
{
    const string path = @"C:/Repo/advent of code/input/input1.txt";
    public FileHandler()
    {

    }

    public async Task<string[]> GetLines()
    {
        Console.WriteLine($"Reading all lines for: '{path}'");
        var lines = await File.ReadAllLinesAsync(path);
        Console.WriteLine($"Done Reading all lines for: '{path}'");
        Console.WriteLine($"Found {lines.Length} lines for: '{path}'");
        return lines;
    }
}
