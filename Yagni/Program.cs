using YagniExample;

namespace Yagni;

public class Program
{
    public static void Main()
    {
        // Aplying YAGNI
        GuessTheNumberYagni game = new GuessTheNumberYagni();
        game.startGame();

        // No applying YAGNI
        GuessTheNumberNoYagni gameNoYagni = new GuessTheNumberNoYagni();
        gameNoYagni.startGame();
    }
}
