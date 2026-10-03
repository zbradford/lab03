/*
* Name: Z Bradford
* Course: CSCI 1250, Section 201
* Assignment: Lab 03, The Badge Office
* Date: Octctober 04, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/

// == Part 0: Random ==
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
Console.WriteLine(" ");
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

Console.Write("Walking speed in feet per second: ");
string walkSpeed = Console.ReadLine();

// -- Calculations --
Convert.ToDouble(dormX);
Convert.ToDouble(dormY);
Convert.ToDouble(classX);
Convert.ToDouble(classY);

// Distance
Math.Sqrt(Math.Pow(Convert.ToDouble(classX) - Convert.ToDouble(dormX) , 2) + Math.Pow(Convert.ToDouble(classY) - Convert.ToDouble(dormY), 2));
double distance = Math.Sqrt(Math.Pow(Convert.ToDouble(classX) - Convert.ToDouble(dormX) , 2) + Math.Pow(Convert.ToDouble(classY) - Convert.ToDouble(dormY), 2));

//Time
double timeInSeconds = Convert.ToInt32(distance) / Convert.ToDouble(walkSpeed);
double timeInMinutes = timeInSeconds / 60;
int remaningSeconds = Convert.ToInt32(timeInSeconds) % 60;

// -- Output --
Console.WriteLine(" ");
Console.WriteLine("Distance: " + distance.ToString("F1"));
Console.WriteLine("Walk time: " + timeInMinutes.ToString("F0") + " minutes " + remaningSeconds.ToString("F0") + " seconds");

// == Part 4: The Badge ===
// -- Calculations --
int checkDigit = studentID % 9;

// -- Output --
Console.WriteLine(" ");
Console.WriteLine("==================================");
Console.WriteLine(" ETSU STUDENT BAGDE");
Console.WriteLine("==================================");
Console.WriteLine("NAME        " + nameOnBadge);
Console.WriteLine("USERNAME    " + username);
Console.WriteLine("ID          " + studentID + "-" + checkDigit);
Console.WriteLine("Locker      " + locker);
Console.WriteLine("Walk        " + timeInMinutes.ToString("F0") + " min " + remaningSeconds.ToString("F0") + " sec");