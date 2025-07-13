using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stringmanipulations1
    


    {
        static void Main()
        {
            // Step 1: Accept a string
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Step 2: Print the string in reverse order
            char[] reversedArray = input.ToCharArray();
            Array.Reverse(reversedArray);
            string reversed = new string(reversedArray);
            Console.WriteLine("Reversed string: " + reversed);

            // Step 3: Extract from 2nd position till end
            if (input.Length > 1)
            {
                string extracted = input.Substring(1);
                Console.WriteLine("Substring from 2nd character: " + extracted);
            }
            else
            {
                Console.WriteLine("Cannot extract from 2nd character: string too short");
            }

            // Step 4: Replace a character with '$' in a copy of the string
            Console.Write("Enter character to replace with $: ");
            char ch = Console.ReadLine()[0];

            string copy = string.Copy(input);        // Make a copy of original
            string modified = copy.Replace(ch, '$'); // Modify the copy

            // Step 5: Print both original and modified strings
            Console.WriteLine("Original string: " + input);
            Console.WriteLine("Modified string: " + modified);
        }
    }

}

