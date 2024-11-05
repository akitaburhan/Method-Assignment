namespace MethodAssignmentApp
{
    // Define a class to contain the math operation
    public class MathOperation
    {
        // Method that takes two integers as parameters, with the second parameter being optional
        public int CalculateSum(int number1, int number2 = 5)
        {
            // Perform addition and return the result
            return number1 + number2;
        }
    }
}