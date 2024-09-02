using ConsoleApp1.Abstractions;
using ConsoleApp1.Classes;
using ConsoleApp1.Classes.Sorts;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Introduction()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********");
            Console.WriteLine("Welcome");
            Console.WriteLine("********");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("This is my console application for sorting,searching and scrambling generic values inside a list");
        }
        static void Choices()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Here are your options:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1) Insert elements into a list");
            Console.WriteLine("2) Sort elements in the list");
            Console.WriteLine("3) Search elements in the list");
            Console.WriteLine("4) Scramble already existing list");
            Console.WriteLine("5) Exit program");
            Console.WriteLine("Choose an option: ");
        }

        static void RunCase1()
        {
            Console.WriteLine();
            Console.WriteLine("Input numerical values");
        }
        static void RunCase2()
        {

        }
        static void RunCase3()
        {

        }
        static void RunCase4()
        {

        }

        static void RunConsoleApp()
        {
            List<int> list = new List<int>()
            {
                1,5,2,6,3,4
            };
            SortStrategy<int> sort = new InsertionSort<int>();
            sort.Sort(list);
            Console.WriteLine(String.Join(',', list));
            Scrambler scrambler = Scrambler.GetInstance();
            scrambler.Scramble(list);
            Console.WriteLine(String.Join(',', list));
            int choice;
            
        }

        static void Main(string[] args)
        {
            Introduction();
            Choices();
            int userInput;
            do
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1: RunCase1();
                        break;
                    case 2: RunCase2();
                        break;
                    case 3: RunCase3();
                        break;
                    case 4: RunCase4();
                        break;
                    default:
                        break;
                }
            } while (userInput != 5);
        }
    }
}
