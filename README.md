# Method-Assignment
Explanation and Comments:
Optional Parameter in Method:

The CalculateSum method in MathOperation class takes two integers, with number2 being optional (defaulting to 5).
If the second argument isn’t provided, number2 will automatically be 5.
User Input and Conditional Logic in Main:

The program prompts the user for the first number, which is required.
For the second number, the user can either enter a value or press Enter to skip.
Using string.IsNullOrWhiteSpace(input), the program checks if the second input is empty. If so, it calls CalculateSum with one parameter; otherwise, it calls the method with both.
Display Result:

After calling the method, the result is displayed to the user.
Example Scenarios:
If the user enters 10 as the first number and presses Enter without entering a second number, the method adds 10 + 5 (default) and returns 15.
If the user enters 10 and 20, the method adds 10 + 20 and returns 30.
