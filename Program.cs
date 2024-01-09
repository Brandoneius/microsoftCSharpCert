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
string response = (permission.Contains("Admin") || level >= 55 ? "Welcome, Super Admin User" : "Not a super user");

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



//SWITCH STATEMENTS
//Same syntax as a PHP switch statement! Including breaks and multiple cases
//Switches in C# do not need to have a default value

int employeeLevel = 300;
string employeeName = "Hugh Mungus";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

//Refactor this into switch statements:
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

//This operator turns the string into an array split on the - character. 
string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;

}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}


Console.WriteLine($"Product: {size} {color} {type}");



//FOR Statement
//Useful for multidimensional arrays that the foreach loop would not work
//Same syntax as Python!

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//Loop through an array with the for

string[] names = { "Raya", "Molly", "Brandon", "Ares" };

for (int i = 0; i < names.Length; i++)
{
    //If the name is Ares, we want to change it to Gunter! 
    if (names[i] == "Ares")
    {
        names[i] = "Gunter";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}

/*
 * 
 * ->The for iteration statement allows you to iterate through a block of code a specific number of times.
   ->  The for iteration statement allows you to control every aspect of the iteration's mechanics by altering the three conditions inside the parenthesis: the initializer, condition, and iterator.
   ->It's common to use the for statement when you need to control how you want to iterate through each item in an array.
If your code block has only one line of code, you can eliminate the curly braces and white space if you wish.
 * 
 */


/*
 * Here are the FizzBuzz rules that you need to implement in your code project:
Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
 * 
 * 
 */

string fizzBuzz = string.Empty;
for (int i = 1; i < 101; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        fizzBuzz = "- FizzBuzz";
    } else if(i % 5 == 0)
    {
        fizzBuzz = "- Buzz";
    } else if (i % 3 == 0)
    {
        fizzBuzz = "- Fizz";
    }

    Console.WriteLine($"{i} {fizzBuzz}");
    fizzBuzz = "";
}

//DO WHILE LOOP

Random random = new Random();
int current = 0;
int numberOfIterations = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
    numberOfIterations++;
} while (current != 7);

Console.WriteLine($"Number of iterations until 7 is rolled: {numberOfIterations}");


//Monster Game do While Loop
//Player attacks first

Random attackDamageInstance = new Random();
int playerHP = 10;
int monsterHP = 10;
bool gameOver = false;

do
{
    //Player attacks first
    int playerDamage = attackDamageInstance.Next(1, 11);
    monsterHP -= playerDamage;
    Console.WriteLine($"Monster was damaged and lost {playerDamage} and now has {monsterHP} health.");
    if (monsterHP <= 0)
    {
        Console.WriteLine("Player Wins! :D");
        gameOver = true;
        break;
    }

    //Monster Attacks
    int monsterDamage = attackDamageInstance.Next(1, 11);
    playerHP -= monsterDamage;
    Console.WriteLine($"Hero was damaged and lost {monsterDamage} and now has {playerHP} health.");
    if (playerHP <= 0)
    {
        Console.WriteLine("Monster Wins! :(");
        gameOver = true;
        break;
    }

} while (!gameOver);

//The solved solution had a pretty good idea with the ternary operator for this

/*
 * 
 * while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

*/

//Interesting Syntax Alert!!!!
//Question Mark after the string type declaration is a nullable type string
//This do while loop will keep running until a null string has been submitted by the user
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);

bool runningNumberScript = true;
bool isNumber = false;
int userSubmittedNumber = 0;

Console.WriteLine("Enter an integer value between 5 and 10");
string userInput = "";
do
{
    userInput = Console.ReadLine();
    //Cool method here, the TryParse method will give a True response if this is a number, and reassign the userSubmittedNumber in the same line
    isNumber = int.TryParse(userInput, out userSubmittedNumber);

    if (isNumber)
    {
        if (userSubmittedNumber >= 5 && userSubmittedNumber <= 10)
        {
            Console.WriteLine($"Your input value of ({userSubmittedNumber}) has been accepted");
            runningNumberScript = false;
        } else
        {
            Console.WriteLine($"You entered {userSubmittedNumber}. Please enter a number between 5 and 10");
        }
    } else
    {
        Console.WriteLine("Sorry, you entered an invalid number. Please try again!");
    }


} while (runningNumberScript);