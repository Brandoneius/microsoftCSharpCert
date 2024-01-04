using System;
//Use the system class Random to get a random number and roll. 
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//An instance of a class is called an Object.
//Need to use the new operator to create the new secondDie object.
//When calling the new operator on the randon class a few things are done.
//1.) requests an address in the computers memory large enough to store the new object based on the Random class
//2.) Creates a new object and stores it in the memory address
//3.) Returns the memory address so the it can be saved in the secondDie variable
Random secondDie = new Random();
int secondDieResult = secondDie.Next(1,7);

//String interporlation example. Need to curly braccket every instance of the variable
//Cannot simply write {roll & secondDieResult}
Console.WriteLine($"You have rolled a {roll} & {secondDieResult}");

//There is a big difference between calling a Stateless and Stateful method.
//A stateless method does not need to be created with the new keyword
//A stateful method must be created with a new keyword.
//Similar to calling new instances of classes in PHP $account = new Account();

//Void Methods are methods that are designed to not return a value when they are finsihed

//Parameter vs Argument
//Parameter is what is inside the method, while the argument is the value that is being passed through the method

//Overloaded Methods
//Some methods are called overloaded methods, meaning they can different versions that can
//accept differnt data types
//Console.WriteLine() is an example of this, we can call this method with int, string, etc, but not combined

//Three examples of overloading in a method
//We can can call the next method different ways to get different ranges
Random die = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First Roll: {roll1}");
Console.WriteLine($"Second Roll: {roll2}");
Console.WriteLine($"Third Roll: {roll3}");


int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);

//Logic Excercise C#

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration <= 10 && daysUntilExpiration > 5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
} else if(daysUntilExpiration <=5 && daysUntilExpiration > 1)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");

} else if(daysUntilExpiration == 1){
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expire within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
} else if(daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");

} else
{
    
}


//Arrays in C#
//Declare a new array
string[] fraudulentOrderIDs = new string[3];

//Outside of the explicit typing and defining the number of elements that can be stored in an array
//The syntax for accessing elements in the array is the same as PHP

//Can also initialize an array same way PHP
//string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

//Tons of built in methods for arrays like .Length to get how many elements are in the array

//For loops!!!
foreach (string fraud in fraudulentOrderIDs)
{
    Console.WriteLine(fraud);
}