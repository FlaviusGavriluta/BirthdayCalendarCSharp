using Codecool.BirthdayCalendar.Calendar;
using Codecool.BirthdayCalendar.Generators;
using Codecool.BirthdayCalendar.Users;

IRandomDateGenerator randomDateGenerator = new RandomDateGenerator(1970, 2010);
IRandomUserGenerator randomUserGenerator = new RandomUserGenerator(randomDateGenerator, 200);

IUserRepository userRepository = new UserRepository(randomUserGenerator);
IUserAgeCalculator userAgeCalculator = new UserAgeCalculator();

IBirthdayCalendar birthdayCalendar = new BirthdayCalendar(userRepository, userAgeCalculator, 2022);

Console.WriteLine("Birthdays:\n");

foreach (var birthDate in birthdayCalendar.GetBirthdaysForMonth(3))
{
    Console.WriteLine($"{birthDate.Key.ToShortDateString()}: {string.Join(", ", birthDate.Value.Select(u => $"{u.User.UserName} [{u.AgeInYears} years old]"))}");
}

Console.ReadKey();




