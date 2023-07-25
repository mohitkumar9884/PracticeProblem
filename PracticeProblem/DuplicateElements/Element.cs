using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.DuplicateElements
{
    internal class Element
    {
        public void Dupliment()
        {
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6, 6, 6, 7, 8, 9, 0, 0, 0 };

            int duplicatesCount = CountDuplicateElements(array);
            Console.WriteLine("Total number of duplicate elements: " + duplicatesCount);
        }

        public int CountDuplicateElements(int[] arr)
        {
            int dupli = 0; // store duplicate elements
            Dictionary<int, int> elemount = new Dictionary<int, int>(); // count of occurrences of elements in the array name of dictionary elemount

            // Count the occurrences of elements
            foreach (int num in arr)
            {
                if (elemount.ContainsKey(num))
                    elemount[num]++;
                else
                    elemount[num] = 1;
            }

            // Count the total duplicates
            foreach (int value in elemount.Values)
            {
                if (value > 1)
                    dupli++;
            }

            return dupli;
        }

    }
}
