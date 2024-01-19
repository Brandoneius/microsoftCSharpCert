string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses

}

internalDomainAddress(corporate);

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
}

externalDomainAddress(external, externalDomain);

void internalDomainAddress(string[,] userNames)
{
    //Note to loop through multidemsional arrays 
    for (int i=0; i< userNames.GetLength(0); i++)
    {
        string first_two = userNames[i, 0].Substring(0,2).ToLower();
        string email = first_two + userNames[i, 1].ToLower() + "@contoso.com";
        Console.WriteLine($"{email}");
    }
}

void externalDomainAddress(string[,] userNames,string externalEmail)
{
    //Note to loop through multidemsional arrays 
    for (int i = 0; i < userNames.GetLength(0); i++)
    {
        string first_two = userNames[i, 0].Substring(0, 2).ToLower();
        string email = first_two + userNames[i, 1].ToLower() + externalEmail;
        Console.WriteLine($"{email}");
    }
}



double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

Console.WriteLine($"Total: ${total}");

//Always need to assign the type of return value from methods in C#
//If the method does not return any value, use the void keyword
//As in the return is void 
double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    double result = items[itemIndex] * (1 - discounts[itemIndex]);
    return result;
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0,5);
}

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
} else
{
    Console.WriteLine($"Total does not mean minium {total}");
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    //This is cool, you can call functions and their return value within string interpolation! 
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}


//DICE GAME CHALLENGE
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
string initialAnswer = Console.ReadLine();
if (ShouldPlay(initialAnswer))
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        //Code solution created methods for these and left them as var data types
        //I dont see the big difference in doing this vs my solution
        int target = random.Next(1,6);
        int roll = random.Next(1,7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        string ?continuePlaying = Console.ReadLine();
        play = ShouldPlay(continuePlaying);
    }
}

bool ShouldPlay(string answer)
{
    string answerTrimmed = answer.ToLower().Trim();
    if (answerTrimmed == "y")
    {
        return true;
    }else
    {
        return false;
    }
}

string WinOrLose(int targetNumber, int playerRoll)
{
    if(targetNumber > playerRoll)
    {
        return "You lose!";
    } else
    {
        return "You win!";
    }
}