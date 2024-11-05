using System;

namespace MethodAssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperation class
            MathOperation operation = new MathOperation();

            // Ask the user to enter the first number
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the second number (optional)
            Console.Write("Enter the second number (or press Enter to skip): ");
            string input = Console.ReadLine();

            // Determine if the user entered a second number
            int result;
            if (string.IsNullOrWhiteSpace(input))
            {
                // Call the method with only one argument
                result = operation.CalculateSum(num1);
            }
            else
            {
                // Convert the input to an integer and call the method with both arguments
                int num2 = Convert.ToInt32(input);
                result = operation.CalculateSum(num1, num2);
            }

            // Display the result
            Console.WriteLine("The result of the calculation is: " + result);

            // Keep the console open
            Console.ReadLine();
        }
    }
}