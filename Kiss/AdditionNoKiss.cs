using System.Text.RegularExpressions;

namespace KissExample;

/*
Version where KISS is not respected:
This is a simple Addition, but here there additionals methods such as IsValidNumber, ConvertToNumber,
SumNumbers and DisplayResult that is not estrictly necessary for this addition operation. Here is
added a complexity addional that Which does not add significant value to the functionality.
*/
public class AdditionNoKiss
{
    public static void Main()
    {
        Console.WriteLine("-> Enter the first number: ");
        string input1 = Console.ReadLine();
        if (!IsValidNumber(input1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number");
            return;
        }     
        double number1 = ConvertToNumber(input1);

        Console.WriteLine("-> Enter the second number: ");
        string input2 = Console.ReadLine();
        if (!IsValidNumber(input2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number");
            return;
        }       
        double number2 = ConvertToNumber(input2);

        double result = SumNumbers(number1, number2);
        DisplayResult(result);
    }

    private static bool IsValidNumber(string input)
    {
        return Regex.IsMatch(input, @"^-?\d+(\.\d+)?$");
    }

    private static double ConvertToNumber(string input)
    {
        return double.Parse(input);
    }

    private static double SumNumbers(double num1, double num2)
    {
        return num1 + num2;
    }

    private static void DisplayResult(double result)
    {
        Console.WriteLine($"The result is: {result}");
    }
}
