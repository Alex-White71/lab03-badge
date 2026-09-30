/*
* Name: Alex White
* Course: CSCI 1250, Section 002
* Assignment: Lab 03, The Badge Office
* Date: September 30, 2026
* Description: Builds a student badge from a name, two random assignments,
* and the walking distance to a first class.
*/
// Part 1 Ask user for full name before displaying the name on badge as well as username, Initials, and letters
Console.Write("What is your first and last name? ");
string fullName = Console.ReadLine();
fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string fullNameNoSpace = firstName.Trim() + lastName.Trim();
string userName = fullNameNoSpace.ToLower();
string badgeNameFirst = firstName.ToUpper();
string badgeNameLast = lastName.ToUpper();
string firstInitial = firstName.Substring(0, 1);
string lastInitial = lastName.Substring(0, 1);
string upperFirstInitial = firstInitial.ToUpper();
string upperLastInitial = lastInitial.ToUpper();
int lettersInLastName = lastName.Length;
Console.WriteLine($"Name on badge: {badgeNameFirst} {badgeNameLast}");
Console.WriteLine($"Username: {userName}");
Console.WriteLine($"Initials: {upperFirstInitial}.{upperLastInitial}");
Console.WriteLine($"Letters in last name: {lettersInLastName}");
// assigns a student ID and locker based on a random number
Random rng = new Random();
int studentID = rng.Next(100000, 999999 +1);
int locker = rng.Next(1, 501);
Console.WriteLine($"Student ID: {studentID}");
Console.WriteLine($"Locker: {locker}");