using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Head_Body_Tail
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter first string:");
                string mainStr = Console.ReadLine();

                Console.WriteLine("Enter second string:");
                string head = Console.ReadLine();

                Console.WriteLine("Enter third string:");
                string body = Console.ReadLine();

                Console.WriteLine("Enter fourth string:");
                string tail = Console.ReadLine();

                Console.WriteLine(VerifySubstrs(mainStr, head, body, tail));
                Console.ReadKey();
            }

            public static string VerifySubstrs(string mainStr, string head, string body, string tail)
            {
                if (mainStr.StartsWith(head) && mainStr.Contains(body) && mainStr.EndsWith(tail))
                {
                    return "My head, body, and tail.";
                }
                else
                {
                    return "Incomplete";
                }
            }
        }
    }