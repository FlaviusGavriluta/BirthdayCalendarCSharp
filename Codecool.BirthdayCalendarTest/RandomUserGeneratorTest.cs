using Codecool.BirthdayCalendar.Generators;
using Moq;

namespace Codecool.BirthdayCalendarTest;

public class RandomUserGeneratorTest
{
    private const int UserCount = 20;
    private readonly DateTime _mockedDate = new(1992, 7, 21);
    private IRandomUserGenerator _randomUserGenerator;

    [SetUp]
    public void Setup()
    {
        var mock = new Mock<IRandomDateGenerator>();
        mock.Setup(r => r.Generate()).Returns(_mockedDate);

        _randomUserGenerator = new RandomUserGenerator(mock.Object, UserCount);
    }

    [Test]
    public void GeneratesCorrectNumberOfUsers()
    {
    }

    [Test]
    public void CreatesUsersWithCorrectBirthDate()
    {

    }
}
