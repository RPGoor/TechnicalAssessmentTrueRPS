using TrueRPS;

internal class Program
{
    private static void Main(string[] args)
    {
        GameState game = new GameState();

        while (true)
        {

            Console.WriteLine($"Please choose a hand to play using one of the numbers(q to quit):\n{EnumHelper<Hands>.GetPrettyPrintNames(game.AvailableHands)}");
            if(!UserInputHandler.HandleUserEnumSelection<Hands>(out Hands userHand) || !game.Running)
            {
                continue;
            }

            var computerHand = game.Computer.GenerateComputerHand(game.AvailableHands);
            if (userHand == computerHand)
            {
                Console.WriteLine("Tie");
                continue;
            }
            else if (GameLogic.Beats(userHand, computerHand))
            {
                Console.WriteLine($"{userHand} beats {computerHand}, You win!");
            }
            else
            {
                Console.WriteLine($"{userHand} loses to {computerHand}, You lose.");
            }

            if (game.Computer is ComputerPlayer2 computer2)
            {
                computer2.PrevPlayerHand = userHand;
            }
        }
    }
}