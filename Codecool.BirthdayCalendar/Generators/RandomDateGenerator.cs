namespace Codecool.BirthdayCalendar.Generators;

public class RandomDateGenerator : IRandomDateGenerator
{
    private static readonly Random Random = new();

    private static readonly Dictionary<int[], (int Min, int Max)> DayGenerators = new()
    {
        { new[] { 1, 3, 5, 7, 8, 10, 12 }, (1, 31) },
        { new[] { 4, 6, 9, 11 }, (1, 30) },
        { new[] { 2 }, (1, 28) },
    };

    private readonly int _minYear;
    private readonly int _maxYear;

    public RandomDateGenerator(int minYear, int maxYear)
    {
        _minYear = minYear;
        _maxYear = maxYear;
    }

    public DateTime Generate()
    {
        var year = GetRandomYear();
        var month = GetRandomMonth();
        var day = GetRandomDay(year, month);

        return new DateTime(year, month, day);
    }

    private int GetRandomYear()
    {
        return Random.Next(_minYear, _maxYear + 1);
    }

    private static int GetRandomMonth()
    {
        //Upper bound is exclusive
        return Random.Next(1, 12 + 1);
    }

    private static int GetRandomDay(int year, int month)
    {
        var generator = DayGenerators.First(g => g.Key.Contains(month)).Value;
        return Random.Next(generator.Min, generator.Max + (month == 2 && IsLeapYear(year) ? 2 : 1));
    }

    private static bool IsLeapYear(int year) => year % 4 == 0;
}
