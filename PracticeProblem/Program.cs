using PracticeProblem.DuplicateElements;
using PracticeProblem.FrequencyElement;
using PracticeProblem.UniqueElement;

namespace PracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice problems.");
            Console.WriteLine("Please chose any One program from below options");
            Console.WriteLine("\n1.Dupliment\n2.Uniquelement\n3.Frequelement");
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
                    default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}