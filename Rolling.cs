using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_02
{
    internal class Rolling()
    {
        public void RollDice(int numDice, int[] dice)
        {
            Random rnd = new Random();

            // Generate 2 random numbers and add them together for every die
            for (int i = 0; i < numDice; i++)
            {
                int dieOneNum = rnd.Next(6) + 1; // Returns random number from 1 to 6
                int dieTwoNum = rnd.Next(6) + 1;
                int diceNums = dieOneNum + dieTwoNum; // Add both dice together

                dice[diceNums - 2] += 1; // Add 1 roll to the total for this number
            }
        }
    }
}
