/* 
 * Conditional Operator:
 * <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
 * 
 * Also called ternary conditional operator
 * 
 * 
 */

//Way to use the ternary operator to make this code only 3 lines
using System;

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");


string permission = "|Manager";
int level = 19;

//This is an example of a working ternary operator. Good to know about, but kind of hard to read imo
string response = (permission.Contains("Admin") || level >= 55 ? "Welcome, Super Admin User" : "");

string userResponse = string.Empty;

if (permission.Contains("Admin"))
{
    if(level > 55)
    {
        userResponse = "Welcome, Super Admin user.";
    } else
    {
        userResponse = "Weclome, Admin user.";
    }
} else if (permission.Contains("Manager"))
{
    if(level >= 20)
    {
        userResponse = "Contact an Admin for access.";
    } else
    {
        userResponse = "You do not have sufficent privileges.";
    }
} else
{
    userResponse = "You do not have sufficient privileges";
}

Console.WriteLine(userResponse);

//Variable scope in C#
//C# contains the same variable scope logic as PHP

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;
    if (number == 42)
    {
        found = true;

    }

}

if (found)
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");

