using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveOddNumbers
{
    class SumOfOddNumbersinArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide an array of comma separated numbers");
            string text = Console.ReadLine();
            Console.WriteLine("The array is: {0}", text);
            Console.WriteLine("The sum of odd numbers in the array is: {0}", SumOfOddNumbers.AddOddNumbers(text));
            Console.ReadKey();
        }
    }

   public static class SumOfOddNumbers
        {
            public static int AddOddNumbers(string text)
            {

                int[] numbers = Array.ConvertAll(text.Split(','), int.Parse);

                int odds = 0;

                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {

                    }
                    else
                    {
                        odds += number;
                    }
                }
                return odds;
            }
        }
    }
