/*
* Name: Alex White
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
// Part 1 Ask user for full name before displaying the name on badge as well as username, Initials, and letters
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Schema;

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
Console.WriteLine($"Initials: {upperFirstInitial}.{upperLastInitial}.");
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
Console.Write("What is your walking speed in feet per second? ");
double walkSpeed = Convert.ToDouble(Console.ReadLine());
double stepOneX = classX - dormX;
double stepOneY = classY - dormY;
double stepTwoX = Math.Pow(stepOneX, 2);
double stepTwoY = Math.Pow(stepOneY, 2);
double stepThree = stepTwoX + stepTwoY;
double distance = Math.Sqrt(stepThree);
double timeToClassInSecs = distance/walkSpeed;
double timeToClassInMins = timeToClassInSecs/60;
int minsToClass = Convert.ToInt32(timeToClassInMins);
int secsToClass = Convert.ToInt32(timeToClassInSecs%60);
Console.WriteLine($"Distance: {distance.ToString("F1")} feet");
Console.WriteLine($"Walk Time {minsToClass} minutes {secsToClass} seconds");
Console.WriteLine();
//calculate the check digit and print the final badge
int checkDigit = studentID%9;
string topText = "ETSU STUDENT BADGE";
Console.WriteLine("==================================");
Console.WriteLine("".PadRight(8) +topText);
Console.WriteLine("==================================");
string name = badgeNameFirst + " " + badgeNameLast;
Console.WriteLine("NAME".PadRight(10) + name);
Console.WriteLine("USERNAME".PadRight(10) + userName);
string id = studentID + "-" + checkDigit;
Console.WriteLine("ID".PadRight(10) + id);
Console.WriteLine("LOCKER".PadRight(10) + locker);
string walkTo = minsToClass + " min " + secsToClass + " sec";
Console.WriteLine("WALK".PadRight(10)+ walkTo);
Console.WriteLine("==================================");