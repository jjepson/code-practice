using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodePracticeProvidence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(URLProblem(@"http://www.cnn.com/
https://yahoo.com/testing/path/?redirURL=jj"));
            Console.ReadLine();
            Console.WriteLine(NormalizeProblem(@"()
([)]"));
            Console.ReadLine();
        }

        static string URLProblem(string inURL)
        {
            string[] URLs = Regex.Split(inURL, "\r?\n");
            for (int c = 0; c < URLs.Length; c++)
            {
                System.Uri tmpURI = new Uri(URLs[c]);
                URLs[c] = String.Format("{0},{1},{2}", new string[] { tmpURI.Scheme, tmpURI.Host, tmpURI.Query });
            }
            return String.Join(Environment.NewLine,URLs);
        }

        static string NormalizeProblem(string inPattern)
        {
            string[] Patterns = Regex.Split(inPattern, "\r?\n");
            for (int c = 0; c < Patterns.Length; c++)
            {
                Patterns[c] = isNormalized(Patterns[c]).ToString();
            }
            return String.Join(Environment.NewLine,Patterns);
        }

        static bool isNormalized(string inString)
        {
            char[] openChars = { '{', '(', '[' };
            char[] closeChars = { '}', ')', ']' };
            Stack<char> openStack = new Stack<char>();

            foreach (char tmpChar in inString)
            {
                if(openChars.Contains(tmpChar))
                {
                    openStack.Push(tmpChar);
                }
                if (closeChars.Contains(tmpChar))
                {
                    char tmpOpenChar = openStack.Pop();
                    int tmpOpenCharIndex = Array.IndexOf<char>(openChars,tmpOpenChar);
                    int tmpCloseCharIndex = Array.IndexOf<char>(closeChars, tmpChar);
                    if (tmpOpenCharIndex != tmpCloseCharIndex)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
