using PracticeProblem.Capital;
using PracticeProblem.DuplicateElements;
using PracticeProblem.FrequencyElement;
using PracticeProblem.MaxiMini;
using PracticeProblem.PatternA;
using PracticeProblem.PatternB;
using PracticeProblem.ReverseString;
using PracticeProblem.Sum;
using PracticeProblem.UniqueElement;

namespace PracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice problems.");
            Console.WriteLine("Please chose any One program from below options");
            Console.WriteLine("\n1.Dupliment\n2.Uniquelement\n3.Frequelement\n4.MaxiMini\n5.PatternA\n6.PatternB\n7.ReverseString\n8.Sum\n9.Capital");
            Console.WriteLine(" ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                    case 1:
                    Element element = new Element();
                    element.Dupliment();
                    break;
                    case 2:
                    Unique unique = new Unique();
                    unique.Uniquelement();
                    break; 
                    case 3:
                    Frequency frequency = new Frequency();
                    frequency.Frequelement();
                    break;
                    case 4:
                    MmElement mmElement = new MmElement();
                    mmElement.MaximumMinimum();
                    break; 
                    case 5:
                    Pattern pattern = new Pattern();
                    pattern.A();
                    break;
                    case 6:
                    Patt patt = new Patt();
                    patt.B();
                    break;
                    case 7:
                    ReverseWord reverseWord = new ReverseWord();
                    reverseWord.EachWord();
                    break;
                    case 8:
                    SumNum sumNum = new SumNum();
                    sumNum.Digits();
                    break;
                    case 9:
                    EachCapital eachCapital = new EachCapital();
                    eachCapital.First();
                    break;
                    default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}