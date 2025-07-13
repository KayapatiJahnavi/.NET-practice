using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stringincrement { 
   


    
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string modified = "";

            foreach (char c in input)
            {
                char incremented = (char)(c + 1);

                if (char.IsLetter(incremented))
                {
                    if (char.IsUpper(incremented))
                        modified += char.ToLower(incremented);
                    else
                        modified += char.ToUpper(incremented);
                }
                else
                {
                    modified += incremented;
                }
            }

            Console.WriteLine("Modified String: " + modified);
        }
    }

}

