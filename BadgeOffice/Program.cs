
//Part 1: The Name
using System.Security;

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


//Part 2: The Numbers
Random rng = new Random();
int studentID = rng.Next(100000, 1000000);
int lockerNum = rng.Next(1, 501);
Console.WriteLine("  ");
Console.WriteLine("Student ID: " + studentID);
Console.WriteLine("Locker: " + lockerNum);
Console.WriteLine(" "); 


//Part 3: The Walk
Console.Write("What is the dorm's X? ");
double dormX = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the dorm's Y? ");
double dormY = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the classrom's X? ");
double classX = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the classrom's Y? ");
double classY = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the student's walking speed in feet per second? ");
double speed = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(classX - dormX, 2) + Math.Pow(classY - dormY, 2));
double time = distance/speed;
int timeWhole = Convert.ToInt32(Math.Round(time, 0));
int minute = timeWhole/60;
int second = timeWhole%60;
Console.WriteLine(" ");
Console.WriteLine("Distance: " + Math.Round(distance, 1) + " feet");
Console.WriteLine("Walk time: " + minute + " minutes " + second + " seconds");
Console.WriteLine("  ");