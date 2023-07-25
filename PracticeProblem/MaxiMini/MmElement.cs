using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.MaxiMini
{
    internal class MmElement
    {
        public void MaximumMinimum()
        {
            // Example array
            int[] array = { 500000,189459,354366,467543};

            // Find maximum and minimum elements
            int maxElement = FindMax(array);
            int minElement = FindMin(array);

            // Print the results
            Console.WriteLine("Maximum element: " + maxElement);
            Console.WriteLine("Minimum element: " + minElement);
        }
        public int FindMax(int[] arr)
        {
            int max = arr[0]; // Assume the first element as the maximum

            // Iterate through the array to find the maximum element
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }

            return max;
        }

       public int FindMin(int[] arr)
       {
            int min = arr[0]; // Assume the first element as the minimum

            // Iterate through the array to find the minimum element
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }

            return min;
       }
    }
}
