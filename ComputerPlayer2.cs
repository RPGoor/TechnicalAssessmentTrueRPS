using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueRPS
{
    public class ComputerPlayer2 : IComputerPlayer
    {
        public Hands? PrevPlayerHand { get; set; }
        public Hands GenerateComputerHand(List<Hands> availableHands)
        {
            if(PrevPlayerHand is not null)
            {
                return (Hands)PrevPlayerHand;
            }
            return Extensions.GenerateRandomHand(availableHands);
        }
    }
}
