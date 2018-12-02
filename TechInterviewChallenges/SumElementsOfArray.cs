using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SumElementsOfArray
{
    public static class SumOfNumbers
    {
        public static long AddNumbers(int[] myArray)
        {
            long sum = 0;
            foreach (int number in myArray)
            {
               
                    sum += number;
                
            }
            return sum;
        }
    }
}