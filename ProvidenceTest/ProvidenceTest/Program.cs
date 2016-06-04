using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                Console.WriteLine(isNormalized(line).ToString());
            }
    }

    static bool isNormalized(string inString)
    {
        char[] openChars = { '{', '(', '[' };
        char[] closeChars = { '}', ')', ']' };
        Stack<char> openStack = new Stack<char>();

        foreach (char tmpChar in inString)
        {
            if (openChars.Contains(tmpChar))
            {
                openStack.Push(tmpChar);
            }
            if (closeChars.Contains(tmpChar))
            {
                char tmpOpenChar = openStack.Pop();
                int tmpOpenCharIndex = Array.IndexOf<char>(openChars, tmpOpenChar);
                int tmpCloseCharIndex = Array.IndexOf<char>(closeChars, tmpChar);
                if (tmpOpenCharIndex != tmpCloseCharIndex)
                {
                    return false;
                }
            }
        }
        return true;
    }


    static string splitURL(string inURL)
    {
        try
        {
            System.Uri tmpURI = new Uri(inURL);
            return String.Format("{0},{1},{2}", new string[] { tmpURI.Scheme, tmpURI.Host, tmpURI.Query.TrimStart('?') }).TrimEnd(',');
        }
        catch (UriFormatException Ex)
        {
            return "";
        }
    }
}