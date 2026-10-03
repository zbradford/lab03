/*
* Name: Z Bradford
* Course: CSCI 1250, Section 201
* Assignment: Lab 03, The Badge Office
* Date: Octctober 04, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

// == Part 0: Random ==
Random rng = new Random(); 

// == Part 1: The Name ==
// -- Input --
Console.Write("Full Name: ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();

// -- Formatting --
// Badge Name
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

// Username
string nameOnBadge = firstName.ToUpper() +(" ") + lastName.ToUpper();
char firstInitial = firstName[0];
string username = firstInitial + lastName;
username = username.ToLower();

// Initials
char lastInitial = lastName[0];
string initials = firstInitial + (".") + lastInitial + (".");

// Letters in last name
int letterInLastName = lastName.Length;

// -- Output --
Console.WriteLine(" ");
Console.WriteLine("Name on badge: " + nameOnBadge);
Console.WriteLine("Username: " + username);
Console.WriteLine("Initials: " + initials.ToUpper());
Console.WriteLine("Letters in last name: " + letterInLastName.ToString());

// == Part 2: The Numbers ==
// -- Calculations --
// Student ID
int studentID = rng.Next(100000, 1000000);

// Locker Number
int locker = rng.Next(1, 501);

// -- Output --
Console.WriteLine(" ");
Console.WriteLine("Student ID: " + studentID.ToString());
Console.WriteLine("Locker: " + locker.ToString());

// == Part 3: The Walk ===
// -- Input --
Console.Write("Dorm X: ");
string dormX = Console.ReadLine();

Console.Write("Dorm Y: ");
string dormY = Console.ReadLine();

Console.Write("Class X: ");
string classX = Console.ReadLine();

Console.Write("Class Y: ");
string classY = Console.ReadLine();

Console.Write("Walk Speed: ");
string walkSpeed = Console.ReadLine();

// -- Calculations --
Convert.ToDouble(dormX);
Convert.ToDouble(dormY);
Convert.ToDouble(classX);
Convert.ToDouble(classY);
double distance = Math.Sqrt(Math.Pow(Convert.ToDouble(classX) - Convert.ToDouble(dormX) , 2) + Math.Pow(Convert.ToDouble(classY) - Convert.ToDouble(dormY), 2));
