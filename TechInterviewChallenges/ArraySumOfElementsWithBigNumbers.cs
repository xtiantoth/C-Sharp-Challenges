using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySumOfElementsWithBigNumbers
{
    class ArraySumOfElementsWithBigNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a comma separated list of numbers.");
            string text = Console.ReadLine();

            string[] numbers = text.Split(',');

            long[] realNumbers = new long[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                realNumbers[i] = long.Parse(numbers[i]);
            }
          
            foreach (var number in realNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Sum of numbers in the array:" + SumOfNumbers.AddNumbers(realNumbers));
            Console.ReadKey();
        }
    }
    public static class SumOfNumbers
    {
        public static long AddNumbers(long[] myArray)
        {
            long sum = 0;
            foreach (long number in myArray)
            {

                sum += number;

            }
            return sum;
        }
    }

}
