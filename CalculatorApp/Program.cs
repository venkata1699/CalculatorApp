using System;

namespace CalculatorApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calculator = new Calculator();
            bool keepRunning = true;

            Console.WriteLine("=========================================");
            Console.WriteLine("           Simple C# Calculator          ");
            Console.WriteLine("=========================================");
            Console.WriteLine("This calculator supports addition, subtraction, multiplication, and division.");
            while (keepRunning)
            {
                PrintMenu();
                string? choice = Console.ReadLine();

                if (choice == "5")
                {
                    keepRunning = false;
                    Console.WriteLine("Goodbye!");
                    continue;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Invalid choice. Please select 1-5.\n");
                    continue;
                }

                double num1 = ReadNumber("Enter first number: ");
                double num2 = ReadNumber("Enter second number: ");
                double result;

                try
                {
                    result = choice switch
                    {
                        "1" => calculator.Add(num1, num2),
                        "2" => calculator.Subtract(num1, num2),
                        "3" => calculator.Multiply(num1, num2),
                        "4" => calculator.Divide(num1, num2),
                        _ => throw new InvalidOperationException()
                    };

                    Console.WriteLine($"Result: {result}\n");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add (+)");
            Console.WriteLine("2. Subtract (-)");
            Console.WriteLine("3. Multiply (*)");
            Console.WriteLine("4. Divide (/)");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice: ");
        }

        private static double ReadNumber(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    return value;
                }

                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
