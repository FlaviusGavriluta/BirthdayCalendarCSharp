using Codecool.BirthdayCalendar.Users;

namespace Codecool.BirthdayCalendar.Statistics;

public interface IUserAgeStatisticsService
{
    IEnumerable<User> OldestUsers { get; }
    IEnumerable<User> YoungestUsers { get; }
    Dictionary<int, IEnumerable<User>> UsersWithSameAgeInYears { get; }
    Dictionary<int, IEnumerable<User>> UsersWithSameAgeInDays { get; }
}