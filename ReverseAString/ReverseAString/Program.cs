using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmpString = "";
            try
            {
                while (tmpString.Length < 1)
                {
                    Console.WriteLine("Enter text to reverse");
                    tmpString = Console.ReadLine();
                }

                tmpString = ReverseString(tmpString);
                Console.WriteLine("Your text in reverse:");
                Console.WriteLine(tmpString);
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("An error has occured.");
            }
        }
        static string ReverseString(string original)
        {
            char[] tmpChar = original.ToCharArray();
            Array.Reverse(tmpChar);
            return new string(tmpChar);
        }
    }
}
