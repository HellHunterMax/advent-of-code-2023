namespace advent_of_code;

public class Game
{
    public async Task Run()
    {
        var fileHandler = new FileHandler();
        var lines = await fileHandler.GetLines();
        var counter = new Counter();

        foreach (var line in lines)
        {
            var number = counter.CountNumber(line);
            counter.AddNumber(number);
        }

        Console.WriteLine($"Total count = '{counter.TotalLinesCount}'");
    }
}
