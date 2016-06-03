using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rNum = new Random();
            int[] theDeck = new int[52];
            for (int c = 0; c < theDeck.Length; c++)
            {
                theDeck[c] = c + 1;
            }
            Print(theDeck);
            Console.ReadLine();
            for (int c = 0; c < rNum.Next(100); c++)
            {
                Shuffle(theDeck);
            }
            Print(theDeck);
            Console.ReadLine();
        }

        static int[] Shuffle(int[] deck)
        {
            Random rNum = new Random();
            int swapIndex = 0;
            int tmpValue = 0;
            
            for (int c = 0; c < deck.Length; c++)
            {
                swapIndex = rNum.Next(deck.Length-1);
                tmpValue = deck[c];
                deck[c] = deck[swapIndex];
                deck[swapIndex] = tmpValue;
            }

            return deck;
        }

        static void Print(int[] deck)
        {
            for (int c = 0; c < deck.Length; c++)
            {
                Console.Write("{0} ", deck[c]);                
            }
            Console.WriteLine(Environment.NewLine);            
        }
    }
}
