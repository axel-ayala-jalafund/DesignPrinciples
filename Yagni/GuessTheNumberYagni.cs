namespace Yagni;
using System;
using Yagni.Utils;

/*
In this example, the YAGNI principle is being respected, this is because all the implemented functionalities
 are being used and are necessary for the program.
*/
public class GuessTheNumberYagni
{
    private static Random random = new Random();
    private int numberToGuess;
    private int attempts;

    public GuessTheNumberYagni()
    {
        numberToGuess = random.Next(1, 100);
        attempts = 0;
    }

    public void startGame()
    {
        Message.printMessage("| Welcome guess the number game!\n| Try to guess the number between 1 and 100.");

        while (true)
        {
            Message.printMessage("-> Enter your guess: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int guess))
            {
                attempts++;
                if (isWon(guess))
                {
                    Message.prinMessageVictoryGame(attempts);
                    break;
                }
                controlGramePlayed(guess);
            }
            else
            {
                Message.printMessage("Invalid input. Enter a number");
            }
        }
    }

    private bool isWon(int guess)
    {
        return guess == numberToGuess;
    }

    private void controlGramePlayed(int guess)
    {
        if (guess < numberToGuess)
        {
            Message.printMessage("Low. Try again");
        }
        else
        {
            Message.printMessage("High. Try again");
        }
    }
}
