﻿//Remove Duplicates from Array
//Create a function that takes an array of items, removes all duplicate items and returns a new array in the same sequential order as the old array(minus duplicates).
//Examples
//["John", "Taylor", "John"] ➞ ["John", "Taylor"]

//[1, 0, 1, 0] ➞ [1, 0]

//['The', 'big', 'cat'] ➞ ['The', 'big', 'cat']
//Notes
//Test cases contain arrays with both strings and numbers.
//Case sensitive.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static object[] RemoveDups(object[] str)
        {
            return str.Distinct().ToArray();
        }
    }
}
