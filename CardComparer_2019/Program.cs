using System;
using System.Collections.Generic;

namespace CardComparer_2019
{
    class Program
    {
        private static List<Card> deck = new List<Card>();
        private static Random random;

        static void Main(string[] args)
        {
            createFiveRandomCards();
            Console.WriteLine("Five random cards:");
            printDeckToConsole();
            CardComparer_byValue cardComparer = new CardComparer_byValue();
            deck.Sort(cardComparer);
            Console.WriteLine("\r\n");
            Console.WriteLine("Those same cards, sorted:");
            printDeckToConsole();
            
            Console.ReadKey();
        }

        private static void printDeckToConsole()
        {
            foreach (var card in deck)
            {
                Console.WriteLine(card.Name);
            }
        }

        private static void createFiveRandomCards()
        {
            random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Card card = new Card()
                {
                    Value = (Values)random.Next(1, 14),
                    Suit = (Suits)random.Next(1,4)
                };
                deck.Add(card);
            }
        }
    }
}
