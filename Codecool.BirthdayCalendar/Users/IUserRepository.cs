namespace Codecool.BirthdayCalendar.Users;

public interface IUserRepository
{
    User GetById(int id);
    IEnumerable<User> GetAll();
}