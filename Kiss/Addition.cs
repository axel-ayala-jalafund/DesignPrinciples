namespace KissExample;

/*
Correct version:
The code is simple and direct, a simple sum that verify if the input is valid and then just show
the result, in this implementation that is not divided into aditionality methods.
*/
public class Addition
{
    public static void Main()
    {
        Console.WriteLine("-> Enter the first number: ");
        string number1 = Console.ReadLine();
        if (!double.TryParse(number1, out double num1))
        {
            Console.WriteLine("Invalid input. Please enter a valid number");
            return;
        }        

        Console.WriteLine("-> Enter the second number: ");
        string number2 = Console.ReadLine();
        if (!double.TryParse(number2, out double num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number");
            return;
        }       

        double result = num1 + num2;
        Console.WriteLine($"The result is: {result}");
    }
}
