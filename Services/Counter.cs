using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;

namespace advent_of_code;

public class Counter
{
    public int TotalLinesCount { get; private set; } = 0;
    private static readonly List<string> valid = new List<string>() {
        "0",
        "zero",
        "1",
        "one",
        "2",
        "two",
        "3",
        "three",
        "4",
        "four",
        "5",
        "five",
        "6",
        "six",
        "7",
        "seven",
        "8",
        "eight",
        "9",
        "nine"
    };

    public void AddNumber(int number)
    {
        TotalLinesCount += number;
    }

    public int CountNumber(string line)
    {
        Console.WriteLine($"going to find number in {line}.");
        var firstNumber = FindFirstNumber(line);
        if (!int.TryParse(firstNumber, out _))
        {
            firstNumber = valid[valid.IndexOf(firstNumber) - 1];
        }
        var lastNumber = FindLastNumber(line);
        if (!int.TryParse(lastNumber, out _))
        {
            lastNumber = valid[valid.IndexOf(lastNumber) - 1];
        }
        if (int.TryParse($"{firstNumber}{lastNumber}", out var count))
        {
            Console.WriteLine($"Found number '{count}' in the following line: '{line}'");
            return count;
        }
        Console.WriteLine($"ERROR: Could not find number in the following line:'{line}'");
        return 0;
    }

    private static string FindFirstNumber(string line)
    {
        var sb = new StringBuilder();
        foreach (var character in line)
        {
            sb.Append(character);
            foreach (var number in valid)
            {
                if (sb.ToString().Contains(number))
                {
                    return number;
                }

            }
        }
        Console.WriteLine($"ERROR: Could not find number in the following line:'{line}'");
        return "";
    }

    private static string FindLastNumber(string line)
    {
        var sb = new StringBuilder();
        for (int i = line.Length - 1; i >= 0; i--)
        {
            sb.Append(line[i]);
            var text = sb.ToString().ReverseString();
            foreach (var number in valid)
            {
                if (text.Contains(number))
                {
                    return number;
                }
            }
        }
        Console.WriteLine($"ERROR: Could not find number in the following line:'{line}'");
        return "";
    }
}
