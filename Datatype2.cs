using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Datatype2
    



    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int digitCount = 0;
            int alphabetCount = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
            }

            Console.WriteLine("\nNumber of digits: " + digitCount);
            Console.WriteLine("Number of alphabets: " + alphabetCount);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }

}

