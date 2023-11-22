string? name;
string? lastName;
string? city;
string? age;


Console.Write("Enter your first name: ");
name = Console.ReadLine();

Console.WriteLine("Hello! " + name );

Console.WriteLine("Please enter your last name, age and your city!");

lastName = Console.ReadLine();
age = Console.ReadLine();
city = Console.ReadLine();

if (int.TryParse(age, out int number))
{
    int birthYear = DateTime.Now.Year - number;

    Console.WriteLine("Your full name is: " + name + " " + lastName + " and you were born in " + birthYear + " and you live in " + char.ToUpper(city[0]) + city.Substring(1).ToLower());
}
else
{
    Console.WriteLine("Sadly you didnt write numbers as your age");
}
