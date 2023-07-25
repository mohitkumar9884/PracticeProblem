using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.Sum
{
    internal class SumNum
    {
        public void Digits()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = SumDigits(number);
            Console.WriteLine("Sum of digits: " + sum);
        }
        static int SumDigits(int number)
        {
            int sum = 0;

            // Handle negative numbers  
            number = Math.Abs(number);

            while (number != 0)
            {
                //   last digit add it to the sum
                int lastDigit = number % 10;
                sum += lastDigit;

                // Remove the last digit  
                number /= 10;
            }

            return sum;
        }
    }
}
