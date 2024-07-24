using Yagni.Utils;

namespace YagniExample;

/*
To demonstrate that the Yagni principle is being broken, we can see that a functionality was implemented 
for the game which is the attempt logs, which is a functionality that is not being used and is unnecessary.
*/
public class GuessTheNumberNoYagni
{
    private static Random random = new Random();
    private int numberToGuess;
    private int attempts;
    private Logs logs;

    public GuessTheNumberNoYagni()
    {
        numberToGuess = random.Next(1, 100);
        attempts = 0;
        logs = new Logs();
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

                logs.addLog(attempts); // Innecessary functionality

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
