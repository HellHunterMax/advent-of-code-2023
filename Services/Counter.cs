using Microsoft.VisualBasic;

namespace advent_of_code;

public class Counter
{
    public int TotalLinesCount { get; private set; } = 0;
    const string numbers = "1234567890";

    public int CountNumber(string line)
    {
        Console.WriteLine($"going to find number in {line}.");
        var firstNumber = line.First(x => numbers.Contains(x));
        var lastNumber = line.Last(x => numbers.Contains(x));
        if (int.TryParse($"{firstNumber}{lastNumber}", out var count))
        {
            Console.WriteLine($"Found number '{count}' in the following line: '{line}'");
            return count;
        }
        Console.WriteLine($"ERROR: Could not find number in the following line:'{line}'");
        return 0;
    }

    public void AddNumber(int number)
    {
        TotalLinesCount += number;
    }
}
