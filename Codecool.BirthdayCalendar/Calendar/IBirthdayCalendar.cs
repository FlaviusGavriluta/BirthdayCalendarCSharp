using Codecool.BirthdayCalendar.Users;

namespace Codecool.BirthdayCalendar.Calendar;

public interface IBirthdayCalendar
{
    Dictionary<DateTime, IEnumerable<UserAgeDescriptor>> GetBirthdaysForMonth(int month);
    DateTime GetBirthdateForUser(int id);
    UserAgeDescriptor GetUserAgeAtDate(int id, DateTime date);
}