using Codecool.BirthdayCalendar.Users;

namespace Codecool.BirthdayCalendar.Calendar;

public class BirthdayCalendar : IBirthdayCalendar
{
    private readonly IUserRepository _userRepository;
    private readonly IUserAgeCalculator _userAgeCalculator;
    private readonly Dictionary<DateTime, IEnumerable<UserAgeDescriptor>> _dates;

    public BirthdayCalendar(IUserRepository userRepository, IUserAgeCalculator userAgeCalculator, int year)
    {
        _userRepository = userRepository;
        _userAgeCalculator = userAgeCalculator;
        _dates = new Dictionary<DateTime, IEnumerable<UserAgeDescriptor>>();

        var startDate = new DateTime(year, 1, 1);
        var endDate = new DateTime(year, 12, 31);

        var users = userRepository.GetAll().ToList();

        FillCalendar(users, startDate, endDate);
    }

    private void FillCalendar(List<User> users, DateTime startDate, DateTime endDate)
    {
    }

    private static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
    {
        for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
            yield return day;
    }

    public Dictionary<DateTime, IEnumerable<UserAgeDescriptor>> GetBirthdaysForMonth(int month)
    {
        return null;
    }

    public DateTime GetBirthdateForUser(int id)
    {
        return DateTime.Now;
    }

    public UserAgeDescriptor GetUserAgeAtDate(int id, DateTime date)
    {
        return null;
    }
}
