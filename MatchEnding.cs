using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a function that takes two strings and returns true if the first argument ends with the second argument; otherewise return false .
//Rules
//Take two strings as arguments.
//Determine if second string matches ending of first string.
//Return boolean value.
//Examples
//"abc", "bc" ➞ true

//"abc", "d" ➞ false

//"samurai", "zi" ➞ false

//"feminine", "nine" ➞ true

//"convention", "tio" ➞ false
//Notes
//All test cases are valid one word strings.

namespace MatchEnding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            string str2 = Console.ReadLine();

            Console.WriteLine(CheckEnding(str1, str2));
            Console.ReadKey();
        }

        static bool CheckEnding(string str1, string str2)
        {
            return str1.EndsWith(str2);
        }
    }
}
