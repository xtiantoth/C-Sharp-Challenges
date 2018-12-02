using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArraysOddNumbers
{
    public static class SumOfOddNumbers
    {
        public static int AddOddNumbers(int[] myArray)
        {
            int odds = 0;

            foreach(int number in myArray)
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