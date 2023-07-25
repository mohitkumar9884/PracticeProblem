using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.UniqueElement
{
    internal class Unique                
    {
        public void Uniquelement()
        {
            // Example array
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 7, 8, 9, 0, 0, 0 };

            // Print unique elements
            PrintUniqueElements(array);

        }
        static void PrintUniqueElements(int[] arr)
        {
            Dictionary<int, int> uelement = new Dictionary<int, int>();

            // Count the occurrences of elements  
            foreach (int num in arr)
            {
                if (uelement.ContainsKey(num))
                    uelement[num]++;
                else
                    uelement[num] = 1;
            }

            // Print the unique elements havinfg only one occurance in the array
            Console.WriteLine("Unique elements in the array:");
            foreach (int num in arr)
            {
                if (uelement[num] == 1)
                    Console.Write(num + " ");
            }
        }
    }
}
