using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueRPS
{
    public class GameState
    {
        public IComputerPlayer Computer { get; set; } = new ComputerPlayer1();
        public GameModes GameMode = GameModes.Normal;
        public List<Hands> AvailableHands { get; set; } = [];

        public bool Running = true;
        public GameState()
        {
            while (true)
            {
                Console.WriteLine($"Choose a computer to play(q to quit):\n{EnumHelper<Computers>.GetPrettyPrintNames()}");
                if (!UserInputHandler.HandleUserEnumSelection<Computers>(out Computers computer) || !Running)
                {
                    continue;
                }

                if (computer == Computers.Normal)
                {
                    Computer = new ComputerPlayer1();
                    break;
                }
                else if (computer == Computers.PreviousSelection) 
                {
                    Computer = new ComputerPlayer2();
                    break;
                }

            }

            while (true)
            {
                Console.WriteLine($"Choose which mode to play(q to quit):\n{EnumHelper<GameModes>.GetPrettyPrintNames()}");
                if (!UserInputHandler.HandleUserEnumSelection<GameModes>(out GameModes gamemode) || !Running)
                {
                    continue;
                }

                GameMode = gamemode;
                AvailableHands = GameLogic.GetAvailableHands(gamemode);
                break;
            }
        }

       
         
    }
}
