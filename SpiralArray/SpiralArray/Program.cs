using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpiralArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //create test matrix
            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            Console.WriteLine("Matrix in standard format." + Environment.NewLine);
            PrintNormal(matrix);
            Console.WriteLine(Environment.NewLine + "Matrix in sprial format." + Environment.NewLine);
            PrintSpiral(matrix);
            Console.WriteLine(Environment.NewLine + Environment.NewLine + "Press enter to exit.");
            Console.ReadLine();
        }

        static void PrintNormal(int[,] sArray)
        {
            int rowCounter = 0;
            int numRows = sArray.GetUpperBound(0) + 1;
            int numCols = sArray.GetUpperBound(1) + 1;
            try
            {
                if (sArray != null && sArray.Length > 0)
                {
                    while (rowCounter < numRows)
                    {
                        for (int i = 0; i < numCols; i++)
                        {
                            Console.Write("{0} ", sArray[rowCounter, i]);
                        }
                        Console.Write(Environment.NewLine);
                        rowCounter++;
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("An error has occured.");
            }
        }

        static void PrintSpiral(int[,] sArray)
        {
            try
            {
                if (sArray != null && sArray.Length > 0)
                {
                    int i = 0;
                    int numRows = sArray.GetUpperBound(0) + 1;
                    int numCols = sArray.GetUpperBound(1) + 1;
                    int rowCounter = 0;
                    int colCounter = 0;

                    while (rowCounter < numRows && colCounter < numCols)
                    {
                        //print first row
                        for (i = colCounter; i < numCols; ++i)
                        {
                            Console.Write("{0} ", sArray[rowCounter, i]);
                        }

                        //increment row
                        rowCounter++;

                        //print last column
                        for (i = rowCounter; i < numRows; ++i)
                        {
                            Console.Write("{0} ", sArray[i, numCols - 1]);
                        }
                        //decrement column
                        numCols--;


                        if (rowCounter < numRows)
                        {
                            //print bottom row in reverse order
                            for (i = numCols - 1; i >= colCounter; --i)
                            {
                                Console.Write("{0} ", sArray[numRows - 1, i]);
                            }
                            //decrement row counter
                            numRows--;
                        }
                        if (colCounter < numCols)
                        {
                            //print rist column in reverse order
                            for (i = numRows - 1; i >= rowCounter; --i)
                            {
                                Console.Write("{0} ", sArray[i, colCounter]);
                            }
                            //increment column counter
                            colCounter++;
                        }

                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine("An error has occured.");
            }
        }
    }
}
