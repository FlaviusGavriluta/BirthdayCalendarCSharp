using Codecool.BirthdayCalendar.Calendar;
using Codecool.BirthdayCalendar.Users;
using Moq;

namespace Codecool.BirthdayCalendarTest;

public class BirthdayCalendarTest
{
    private static IBirthdayCalendar CreateCalendarWithMockedRepo(IEnumerable<User> users)
    {
        //Create a mock of IUserRepository that upon calling 'GetAll' returns the 'users' list passed in the parameter

        return new BirthdayCalendar.Calendar.BirthdayCalendar(null, new UserAgeCalculator(), 2022);
    }

    [Test]
    public void NoUsersReturnsEmptyCalendar()
    {
    }

    [Test]
    public void GetBirthdaysForMonthInvalidMonthThrowsException()
    {
    }

    [Test]
    public void GetBirthdaysForMonthTwoUsersBornOnTheSameDay()
    {
    }

    [Test]
    public void GetBirthdateForUserNonExistentUserIdThrowsException()
    {
    }

    [Test]
    public void GetBirthDateForUserReturnsCorrectBirthdate()
    {
    }


    [Test]
    public void GetUserAgeAtDateNonExistentUserIdThrowsException()
    {
    }

    [Test]
    public void GetUserAgeAtDateReturnsCorrectAgeDescriptor()
    {
    }
}
