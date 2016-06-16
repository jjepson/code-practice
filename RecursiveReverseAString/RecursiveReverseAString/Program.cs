using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");
            Console.WriteLine(ReverseString("Test"));
            Console.ReadLine();
        }

        static string ReverseString(string original)
        {
            if (original.Length <= 1)
            {
                return original;
            }
            else
            {
                return ReverseString(original.Substring(1))+original[0];
            }
        }
    }
}
