using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveFolderList
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "";
                Console.WriteLine("Please enter a starting path.");
                path = Console.ReadLine();
                while (String.IsNullOrWhiteSpace(path) || !System.IO.Directory.Exists(path))
                {
                    Console.WriteLine("Please enter a valid starting path.");
                    path = Console.ReadLine();
                }
                ListDirectories(path,true);
                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
                Console.ReadLine();
            }
        }

        static void ListDirectories(string path, bool fullPath = true)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (string directory in directories)
                {
                    Console.WriteLine((fullPath) ? directory : new DirectoryInfo(directory).Name);
                    ListDirectories(directory, fullPath);
                }
            }
            catch (DirectoryNotFoundException Ex)
            {
                Console.WriteLine("Invalid Directory");
            }
            catch (UnauthorizedAccessException Ex)
            {
                Console.WriteLine("Access Denied");
            }
        }
    }
}
