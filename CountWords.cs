using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string sentence = Console.ReadLine();
            Console.WriteLine("The string contains {0} words.", Count(sentence));
            Console.ReadKey();
        }
        public static int Count(string sentence)
        {
            string[] splitWords = sentence.Split(" ".ToCharArray());
            int numberOfWords = splitWords.Count();
            return numberOfWords;
        }
    }
}
