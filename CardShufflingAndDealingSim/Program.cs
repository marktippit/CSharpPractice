using System;

namespace CardShufflingAndDealingSim
{
    class Program
    {
        static void Main()
        {
            var myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle();//Place cards in random order

            //display all 52 cards in the order in which they are dealt
            for (var i = 0; i < 52; i++)
            {
                Console.WriteLine($"{myDeckOfCards.DealCard(), -19}");

                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
