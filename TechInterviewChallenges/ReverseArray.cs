using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = { 1, 2, 3, 4, 5, 6 };
            var rev = sequence.Reverse().ToArray();
           
            for (int i = 0; i < rev.Length; i++)
            {
                Console.WriteLine(rev[i]);
            }
            Console.ReadLine();
        }
    }
}
