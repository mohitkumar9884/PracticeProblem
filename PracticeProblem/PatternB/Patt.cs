using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.PatternB
{
    internal class Patt
    {
        public void B()
        {
            int n = 7; //   lines to print
            int m = 7; //   asterisks in each line

            // Loop for each line
            for (int i = 1; i <= n; i++)
            {
                // Print the first or last line  
                if (i == 1 || i == n)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        Console.Write("*");
                    }
                }
                //   lines in between (asterisk at the beginning and end, and spaces in between)
                else
                {
                    Console.Write("*");
                    for (int j = 1; j <= m - 2; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }

                Console.WriteLine(); // Move to the next line 
            }
        }
    }
}
