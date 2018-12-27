//How Many Vowels?
//Create a function that takes a string and returns the number(count) of vowels contained within it.
//Examples
//"Celebration" ➞ 5

//"Palm" ➞ 1

//"Prediction" ➞ 4
//Notes
//a, e, i, o, u are considered vowles(not y).
//All test cases are one word and only contain letters.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine("The number of vowels is: " + CountVowels(str));
            Console.ReadKey();
        }
        public static int CountVowels(string str)
            {
            int VowelCount = 0;

            foreach (var letter in str)
            {
                switch (letter)
                {
                    case 'a':
                        VowelCount++;
                        break;
                    case 'e':
                        VowelCount++;
                        break;
                    case 'i':
                        VowelCount++;
                        break;
                    case 'o':
                        VowelCount++;
                        break;
                    case 'u':
                        VowelCount++;
                        break;
                    default:
                        break;
                }
                
            }
            return VowelCount;
        }
    }
}
