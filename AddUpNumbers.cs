//Add up the Numbers from a Single Number
//Create a function that takes a number as an argument.Add up all the numbers from 1 to the number you passed to the function. For example, if the input is 4 then your function should return 10 because 1 + 2 + 3 + 4 = 10.
//Examples
//AddUp(4) ➞ 10

//AddUp(13) ➞ 91

//AddUp(600) ➞ 180300
//Notes
//Expect any positive number between 1 and 1000.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddUpNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";
           
                beginning:
                Console.WriteLine(Environment.NewLine + "Enter a number between 1 to 1000" + Environment.NewLine);
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Environment.NewLine + "The sum of the elements of the number is:  " + AddUp(num) + Environment.NewLine);
                Console.WriteLine("Do you want to check another number? (y/n)" + Environment.NewLine);
                cont = Console.ReadLine();

            while (cont == "y")
            {
                goto beginning;
            }
            {
                return;
            }
            
        }

        public static int AddUp(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
