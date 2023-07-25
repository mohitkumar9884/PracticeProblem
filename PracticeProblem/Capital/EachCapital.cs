using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.Capital
{
    internal class EachCapital
    {
        public void First()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string convertedSentence = ConvertToTitleCase(sentence);
            Console.WriteLine("Converted sentence: " + convertedSentence);

        }                                                                  //Used built in methods find another way
        static string ConvertToTitleCase(string sentence)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(sentence);
        }
    }
}
