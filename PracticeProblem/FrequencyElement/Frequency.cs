using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.FrequencyElement
{
    internal class Frequency
    {
        public void Frequelement()
        {
            // Example array
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 7, 8, 9, 0, 0, 0 };

            // Count the frequency of each element
            Dictionary<int, int> elequency = new Dictionary<int, int>();

            // Count the occurrences of each element in the array
            foreach (int num in array)
            {
                if (elequency.ContainsKey(num))
                    elequency[num]++;
                else
                    elequency[num] = 1;
            }

            // Print the frequency of each element
            Console.WriteLine("Frequency of each element:");
            foreach (var kvp in elequency)//kvp= key value pair
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
        }
    }
}
