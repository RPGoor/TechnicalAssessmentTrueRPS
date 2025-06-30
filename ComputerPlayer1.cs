using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueRPS
{
    public class ComputerPlayer1 : IComputerPlayer
    {
        public Hands GenerateComputerHand(List<Hands> availableHands)
        {
            return Extensions.GenerateRandomHand(availableHands);
        }
    }
}
