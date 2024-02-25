using System;
using System.Linq.Expressions;
class Calculator
{
    public static void Main(string[] args)
    {

        int number1, number2;
        char operation;

        string allowedOperations = "+-*/";

        Console.WriteLine("Enter an operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        if (!allowedOperations.Contains(operation))
        {
            Console.WriteLine("Operation not allowed");
        }
        else
        {
            Console.WriteLine("Enter number1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"result = {number1 + number2}");
                    break;
                case '-':
                    Console.WriteLine($"result = {number1 - number2}");
                    break;
                case '*':
                    Console.WriteLine($"result = {number1 * number2}");
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        Console.WriteLine($"result = {number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("can not divide by zero");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}