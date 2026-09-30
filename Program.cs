/*
* Name: Alex White
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
// Part 1 Ask user for full name before displaying the name on badge as well as username, Initials, and letters
using System.Security.Cryptography;

Console.Write("What is your first and last name? ");
string fullName = Console.ReadLine();
fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string badgeNameFirst = firstName.ToUpper();
string badgeNameLast = lastName.ToUpper();
string firstInitial = firstName.Substring(0, 1);
string lowerLast = lastName.ToLower();
string userName = firstInitial.ToLower()+lowerLast.Trim();
string lastInitial = lastName.Substring(0, 1);
string upperFirstInitial = firstInitial.ToUpper();
string upperLastInitial = lastInitial.ToUpper();
int lettersInLastName = lastName.Length;
Console.WriteLine($"Name on badge: {badgeNameFirst} {badgeNameLast}");
Console.WriteLine($"Username: {userName}");
Console.WriteLine($"Initials: {upperFirstInitial}.{upperLastInitial}");
Console.WriteLine($"Letters in last name: {lettersInLastName}");
Console.WriteLine();
// assigns a student ID and locker based on a random number
Random rng = new Random();
int studentID = rng.Next(100000, 999999 +1);
int locker = rng.Next(1, 501);
Console.WriteLine($"Student ID: {studentID}");
Console.WriteLine($"Locker: {locker}");
Console.WriteLine();
//calculates the walk to first class from dorm
Console.Write("What is the dorm x value? ");
double dormX = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the dorm y value? ");
double dormY = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the class x value? ");
double classX = Convert.ToDouble(Console.ReadLine());
Console.Write("What is the class y value? ");
double classY = Convert.ToDouble(Console.ReadLine());
Console.Write("What is your walking speed? ");
double walkSpeed = Convert.ToDouble(Console.ReadLine());
double stepOneX = classX - dormX;
double stepOney = classY - dormY;
double stepTwoX = Math.Pow(stepOneX, 2);
double stepTwoY = Math.Pow(stepOney, 2);
double stepThree = stepTwoX + stepTwoY;
double distance = Math.Sqrt(stepThree);

Console.WriteLine($"Distance: {distance.ToString("F1")}");