using Codecool.BirthdayCalendar.Users;

namespace Codecool.BirthdayCalendar.Generators;

public class RandomUserGenerator : IRandomUserGenerator
{
    private readonly IRandomDateGenerator _randomDateGenerator;
    private readonly int _count;

    public RandomUserGenerator(IRandomDateGenerator randomDateGenerator, int count)
    {
        _randomDateGenerator = randomDateGenerator;
        _count = count;
    }

    public IEnumerable<User> Generate()
    {
        for (int i = 0; i < _count; i++)
        {
            var birthDate = _randomDateGenerator.Generate();
            yield return new User(i, $"user{i}", birthDate);
        }
    }
    
}