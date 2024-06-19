namespace Codecool.BirthdayCalendar.Users;

public interface IUserAgeCalculator
{
    public UserAgeDescriptor CreateUserAgeDescriptor(User user, DateTime currentDate);
}