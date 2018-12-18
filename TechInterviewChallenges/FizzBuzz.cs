using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            //Write a program that prints the numbers from 1 to 100. 
            //But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. 
            //For numbers which are multiples of both three and five print “FizzBuzz”."

            for (int i = 0; i < 100; i++)
            {
                int number = i + 1;
                if (number % 3 == 0 && number % 5 == 0)
                {
                    string text = "FizzBuzz";
                    Console.WriteLine(text);

                }
                else if (number % 3 == 0)
                {
                    string text = "Fizz";
                    Console.WriteLine(text);
                }
                else if (number % 5 == 0)
                {
                    string text = "Buzz";
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine(number);
                }
                                
            }
            Console.ReadKey();
        }
    }
}
