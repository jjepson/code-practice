using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordsBeforeAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            string word = "over";
            Console.WriteLine(sentence);
            Console.WriteLine(word);
            Console.WriteLine(GetNum(sentence, word).ToString());
            Console.ReadLine();
        }

        static long GetNum(string sentence, string word)
        {
            int tmpWordLocation = sentence.IndexOf(word);
            int tmpSpaceCount = sentence.Substring(0,tmpWordLocation).Count(x => x == ' ');

            return tmpSpaceCount;
        }
    }
}
