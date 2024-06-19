using Codecool.BirthdayCalendar.Generators;

namespace Codecool.BirthdayCalendar.Users;

public class UserRepository : IUserRepository
{
    private readonly Dictionary<int, User> _users;

    public UserRepository(IRandomUserGenerator randomUserGenerator)
    {
        _users = randomUserGenerator.Generate().ToDictionary(u => u.Id, u => u);
    }

    public User GetById(int id)
    {
        return _users[id];
    }

    public IEnumerable<User> GetAll()
    {
        return _users.Values;
    }
}