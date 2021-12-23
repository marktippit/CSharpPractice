using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShufflingAndDealingSim
{
    class DeckOfCards
    {
        //create one Random object to share among DeckOfCards objects
        private static Random randomNumbers = new Random();

        private const int NumberOfCards = 52; //Number of cards in a deck never changes
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0; //index of next Card to be dealt (0-51)

        public DeckOfCards()
        {
            string[] faces =
            {
                "Ace", "Deuce", "Three", "Four", "Five", "Six",
                "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"
            };
            string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };

            //Populate deck with card objects
            for (var count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        //shuffle deck of Cards with one-pass algorithm
        public void Shuffle()
        {
            //After shuffling, dealing should start at deck[0] again
            currentCard = 0; //reinit currentCard

            //for each card, pick another random Card and Swap them
            for (var first = 0; first < deck.Length; ++first)
            {
                //Select a random card between 0 and 51
                var second = randomNumbers.Next(NumberOfCards);

                //swap current card with randomly selected card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }

        //deal one card
        public Card DealCard()
        {
            //determine whether Cards remain to be dealt
            if (currentCard < deck.Length)
            {
                return deck[currentCard++]; //return current Card in array
            }
            else
            {
                return null; //indicate that all cards were dealt
            }
        }
    }
}

