using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Remove_repeated_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a string remove any repeated letters.
            //Ask for string.
            Console.WriteLine("Enter a string:");

            //Save string in variable.
            string str = Console.ReadLine();
            //Strings are immutable, therefore we make a copy of the original string to work with.
           
            for (int i = 0; i < str.Length;)
            {
                RegexOptions options = RegexOptions.IgnoreCase;
                Regex reg = new Regex(str[i].ToString(), options);
                int CharCount = reg.Matches(str).Count;

                if ( CharCount > 1)
                {
                    str = str.Remove(i, 1);
                }
                else ++i;
            }

            Console.WriteLine(str);
            Console.ReadKey();
        }

        public static bool repeatChar(char character, string remainingString)
        {
            if (remainingString.Contains(character))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        }
    }