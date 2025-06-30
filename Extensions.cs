using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueRPS
{
    public static class Extensions
    {
        public static Hands GenerateRandomHand(List<Hands> availableHands)
        {
            var random = Random.Shared.Next(0, availableHands.Count - 1);
            return availableHands[random];
        }

        public static Hands GenerateRandomHand()
        {
            var random = Random.Shared.Next(0, GetHandsCount() - 1);
            return GetHandFromInt(random);
        }

        public static Hands GetHandFromInt(int index)
        {
            return (Hands)Enum.GetValues(typeof(Hands)).GetValue(index)!;

        }

        public static int GetHandsCount()
        {
            return Enum.GetNames(typeof(Hands)).Length;
        }

    }
}
