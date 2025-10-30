using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result = 0;
            char operation;

            Console.WriteLine("=== Simple Calculator ===");
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator!");
                    return;
            }

            Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
        }
    }
}
