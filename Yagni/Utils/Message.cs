namespace Yagni.Utils;
using System;

public class Message
{
    public static void printMessage(string message) 
    {
        Console.WriteLine(message);
    }

    public static void prinMessageVictoryGame(int attempts)
    {
        Console.WriteLine("Congratz! You guessed the numer in " + attempts + " attempts");
    }
}
