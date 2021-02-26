using System;
using System.Collections.Generic;
using System.Text;

namespace OwensAbilityScoreTester
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            // Divide the roll result by the DivideBy field
            double divide = RollResult / DivideBy;

            // Add AddAmount to the result of the devision
            int added = AddAmount + (int)divide;

            // If the result is to small, use Minimum
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
