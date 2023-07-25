using PracticeProblem.DuplicateElements;
using PracticeProblem.UniqueElement;

namespace PracticeProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice problems.");
            Console.WriteLine("Please chose any One program from below options");
            Console.WriteLine("\n1.Dupliment\n2.Uniquelement");
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
            }
        }
    }
}