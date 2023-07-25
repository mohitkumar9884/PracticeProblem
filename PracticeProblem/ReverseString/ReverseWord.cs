using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.ReverseString
{
    internal class ReverseWord
    {
        public void EachWord()
        {
            string input = "evil rats on no star live";

            string reversedWords = ReverseEachWord(input);
            Console.WriteLine(reversedWords);
        }
        static string ReverseEachWord(string input)
        {
            // Split the input string into individual words
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//Find another way dont use built in methods

            // Reverse each word
            for (int i = 0; i < words.Length; i++)
            {
                char[] wordChars = words[i].ToCharArray();
                Array.Reverse(wordChars);                    //Find another way dont use built in methods
                words[i] = new string(wordChars);
            }

            // Join the reversed words back into a single string
            string reversedString = string.Join(" ", words); //Find another way dont use built in methods

            return reversedString;
        }
    }
}
