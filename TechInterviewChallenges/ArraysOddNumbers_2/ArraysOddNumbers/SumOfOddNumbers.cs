using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArraysOddNumbers
{
    public static class SumOfOddNumbers
    {
        public static int AddOddNumbers(string text)
        {

            int[] numbers = Array.ConvertAll(text.Split(','), int.Parse); 
            
            int odds = 0;

            foreach(int number in numbers)
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