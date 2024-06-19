namespace Codecool.BirthdayCalendar.Users;

public class UserAgeCalculator : IUserAgeCalculator
{
    public UserAgeDescriptor CreateUserAgeDescriptor(User user, DateTime currentDate)
    {
        return CreateDescriptor(user, currentDate);
    }

    private static UserAgeDescriptor CreateDescriptor(User user, DateTime currentDate)
    {
        return new UserAgeDescriptor(user,
            CalculateAgeInYears(user.BirthDate, currentDate), 
            CalculateAgeInDays(user.BirthDate, currentDate));
    }

    private static int CalculateAgeInYears(DateTime birthDate, DateTime currentDate)
    {
        var diffInYears = currentDate.Year - birthDate.Year;
        return DateTime.Now.Month > birthDate.Month ? diffInYears : diffInYears - 1;
    }
    
    private static int CalculateAgeInDays(DateTime birthDate, DateTime currentDate)
    {
        return (int)(currentDate - birthDate).TotalDays;
    }
}