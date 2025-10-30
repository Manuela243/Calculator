using System;

namespace DotNetCalculator
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();
            bool running = true;

            Console.WriteLine("=== .NET Console Calculator ===");
            Console.WriteLine("Type 'exit' at any time to quit.\n");

            while (running)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    string input1 = Console.ReadLine();
                    if (input1.ToLower() == "exit") break;

                    Console.Write("Enter second number: ");
                    string input2 = Console.ReadLine();
                    if (input2.ToLower() == "exit") break;

                    if (!double.TryParse(input1, out double num1) ||
                        !double.TryParse(input2, out double num2))
                    {
                        Console.WriteLine("❌ Invalid input. Please enter valid numbers.\n");
                        continue;
                    }

                    Console.WriteLine("\nChoose operation:");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");
                    Console.Write("Select (1-4): ");

                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "exit") break;

                    OperationType operation = choice switch
                    {
                        "1" => OperationType.Add,
                        "2" => OperationType.Subtract,
                        "3" => OperationType.Multiply,
                        "4" => OperationType.Divide,
                        _ => throw new Exception("Invalid operation choice.")
                    };

                    double result = calc.Calculate(num1, num2, operation);
                    Console.WriteLine($"\n✅ Result: {num1} {GetSymbol(operation)} {num2} = {result}\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("❌ Cannot divide by zero.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"⚠️ Error: {ex.Message}\n");
                }
            }

            Console.WriteLine("Goodbye!");
        }

        static string GetSymbol(OperationType op)
        {
            return op switch
            {
                OperationType.Add => "+",
                OperationType.Subtract => "-",
                OperationType.Multiply => "*",
                OperationType.Divide => "/",
                _ => "?"
            };
        }
    }
}
