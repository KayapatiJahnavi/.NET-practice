using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stringmanipulations
    {
       


        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // 1) Reverse string
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new string(charArray);
            Console.WriteLine("Reversed: " + reversed);

            // 2) Extract from 2nd position (index 1)
            if (input.Length > 1)
            {
                string extracted = input.Substring(1);
                Console.WriteLine("Substring from 2nd character: " + extracted);
            }

            // 3) Replace character
            Console.Write("Enter character to replace: ");
            char ch = Console.ReadLine()[0];
            string replaced = input.Replace(ch, '$');
            Console.WriteLine("After replacement: " + replaced);

            // 4) Copy and modify
            string copy = input;
            string modifiedCopy = copy + "_modified";
            Console.WriteLine("Original string: " + copy);
            Console.WriteLine("Modified copy: " + modifiedCopy);
        }
    }

}

