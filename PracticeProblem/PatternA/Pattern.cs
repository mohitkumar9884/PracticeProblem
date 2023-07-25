using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.PatternA
{
    internal class Pattern
    {
        public void A()
        {
            int n = 8; // The number of lines to print

            // Loop for each line
            for (int i = n; i >= 1; i--)
            {
                // Loop to print asterisks on each line
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line
            }
        }
    }
}
