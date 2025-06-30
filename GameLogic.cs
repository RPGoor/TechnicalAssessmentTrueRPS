using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueRPS
{
    public class GameLogic
    {
        private static readonly Dictionary<Hands, List<Hands>> rules = new Dictionary<Hands, List<Hands>>
        {
            { Hands.Rock, new() { Hands.Scissors, Hands.Lizard } },
            { Hands.Paper, new() { Hands.Rock, Hands.Spock } },
            { Hands.Scissors, new() { Hands.Paper, Hands.Lizard } },
            { Hands.Lizard, new() { Hands.Spock, Hands.Paper } },
            { Hands.Spock, new() { Hands.Scissors, Hands.Rock } }
        };

        public static List<Hands> GetAvailableHands(GameModes mode)
        {
            switch (mode){
                case(GameModes.Normal):
                    return [Hands.Rock, Hands.Paper, Hands.Scissors];
                case(GameModes.LizardSpock):
                    return Enum.GetValues(typeof(Hands)).Cast<Hands>().ToList();
                default:
                    return [];
            }
        }

        public static bool Beats(Hands a, Hands b)
        {
            return rules.TryGetValue(a, out List<Hands>? winHands) && 
                winHands is not null && 
                winHands.Contains(b);
        }
    }
}
