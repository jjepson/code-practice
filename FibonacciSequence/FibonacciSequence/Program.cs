using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long start=0;
            long end=0;

            Console.WriteLine("Fibonacci Printer");
            Console.WriteLine("Enter starting point");
            try
            {
                while (!long.TryParse(Console.ReadLine(), out start) || start < 1)
                {
                    Console.WriteLine("Please enter a valid number greater than zero.");
                }
            }
            catch (OutOfMemoryException Ex)
            {
                Console.WriteLine("Please try a smaller number.");
            }

            Console.WriteLine("Enter ending point");
            try
            {
                while (!long.TryParse(Console.ReadLine(), out end) || end < start)
                {
                    Console.WriteLine("Please enter a valid number that is greater than the start point.");
                }
            }
            catch(OutOfMemoryException Ex)
            {
                Console.WriteLine("Please try a smaller number.");
            }

            try
            {
                Console.Write(Environment.NewLine + "Result:");
                PrintFib(start, end);
                Console.WriteLine(Environment.NewLine+"Press enter to exit.");
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("An error has occured.");
            }

        }
        static void PrintFib(long fromPlace, long toPlace)
        {
            long[] fibArray = GetFib(toPlace);
            for (long i = fromPlace-1; i < toPlace; i++)
            {
                Console.Write("{0} ", fibArray[i]);
            }

        }
        static long[] GetFib(long len)
        {
            long prevNum = 0;
            long curNum = 1;
            List<long> fibArray = new List<long>();
            fibArray.Add(prevNum);
            fibArray.Add(curNum);
            for (long i = 0; i <= len; i++)
            {
                fibArray.Add(prevNum + curNum);
                prevNum = curNum;
                curNum = fibArray.Last<long>();
            }
            return fibArray.ToArray<long>();
        }
    }
}
