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
           
            //Loop through the string to find repeating letters.
            for (int i = 0; i < str.Length;)
            {
                //Ignore uppercase/lowercase
                RegexOptions options = RegexOptions.IgnoreCase;
                
                //Save the character to be searched for in a variable
                Regex reg = new Regex(str[i].ToString(), options);
                
                //Count how many times it occurs in the string.
                int CharCount = reg.Matches(str).Count;

                //If it occurs more than once, remove the first instance.
                if ( CharCount > 1)
                {
                    str = str.Remove(i, 1);
                }
                //If it occurs only once, go on to the next character.
                else ++i;
            }
            
            //Print the modified string.
            Console.WriteLine(str);
            Console.ReadKey();
        }
        }
    }
