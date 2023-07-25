using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.LowestSum
{
    internal class Lowest
    {
        public void Twosum()
        {
            int[] array = {23,372,34,61,93,76,45,57 };

            int[] lowestTwo = FindTwoLowest(array);

            int sum = lowestTwo[0] + lowestTwo[1];
            Console.WriteLine("Two lowest numbers: " + lowestTwo[0] + ", " + lowestTwo[1]);
            Console.WriteLine("Sum of two lowest numbers: " + sum);
        }
        static int[] FindTwoLowest(int[] arr)
        {
            int[] lowestTwo = new int[2];
            lowestTwo[0] = int.MaxValue;
            lowestTwo[1] = int.MaxValue;

            foreach (int num in arr)
            {
                if (num < lowestTwo[0])
                {
                    lowestTwo[1] = lowestTwo[0];
                    lowestTwo[0] = num;
                }
                else if (num < lowestTwo[1])
                {
                    lowestTwo[1] = num;
                }
            }

            return lowestTwo;
        }
    }
}
