// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");

string name = "azhar";

Console.WriteLine(name);


//Write a program to display the addition, subtraction, multiplication and division of two number using console 
//application

Console.WriteLine("Enter the first number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2;
double difference = num1 - num2;
double product = num1 * num2;

double division = (num2 != 0) ? num1 / num2 : double.NaN;

Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

if (!double.IsNaN(division))
{
    Console.WriteLine($"Division: {num1} / {num2} = {division}");
}
else
{
    Console.WriteLine("Division by zero is undefined.");
}

Console.ReadLine(); // Keep console window open until Enter is pressed



//Write a Program to check whether entered number is odd or even


Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"The number {number} is even.");
}
else
{
    Console.WriteLine($"The number {number} is odd.");
}

Console.ReadLine();



//Write a C# Program to Find the Largest Number using Conditional Operator.

Console.WriteLine("Enter the first number:");
int num4 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int num5 = int.Parse(Console.ReadLine());

int largest = (num4 > num5) ? num4 : num5;

Console.WriteLine($"The largest number is: {largest}");

Console.ReadLine();

//Write a C# program to check leap year using conditional Operator.



Console.WriteLine("year:");
int year = int.Parse(Console.ReadLine());

bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

string result = isLeapYear ? "Leap year" : "Not a leap year";
Console.WriteLine($"{year} is {result}");

Console.ReadLine();


//Write a program to implement exception handling in C#.

try
{
    int dividend = 10;
    int divisor = 0;
    int res = dividend / divisor;
    Console.WriteLine("Result of division: " + res);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}

