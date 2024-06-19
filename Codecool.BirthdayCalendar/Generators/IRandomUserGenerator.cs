using Codecool.BirthdayCalendar.Users;

namespace Codecool.BirthdayCalendar.Generators;

public interface IRandomUserGenerator
{
    IEnumerable<User> Generate();
}