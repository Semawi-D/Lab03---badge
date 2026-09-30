
//Part 1: The Name

Console.Write("What is your full name? ");
string name = Console.ReadLine();
string fullName = name.Trim();
int spacePosition= fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string userName = firstName[0] + lastName;
string initials = firstName[0] + "." + lastName[0] + ".";
Console.WriteLine("  ");
Console.WriteLine("Name on badge: " + fullName.ToUpper());
Console.WriteLine("Username: " + userName.ToLower());
Console.WriteLine("Initials: " + initials.ToUpper());
Console.WriteLine("Letters in last name: " + lastName.Length);
Console.WriteLine("  ");

