using System;

namespace CardGameLibrary
{
    class Program
    {
        //public static Array CardDeck()
        //{
        //    int[] cardArray = new int[52];
        //    for (int i = 0; i < 52; i++)
        //    {
        //        cardArray[i] = i;
        //    }
        //    return cardArray;
        //}

        public enum Suit
        {
            Clubs,
            Diamonds,
            Spades,
            Hearts
        }

        public class Card
        {
            String displayName;
            String suit;
            int value;
            public Card(String displayName, String suit, int value)
            {
                this.displayName = displayName;
                this.suit = suit;
                this.value = value;
            }
        }

        public class Deck
        {
            Array deckArray;
            public Deck(Array deckArray)
            {
                this.deckArray = deckArray;
            }
        }
        static void Main(string[] args)
        {
            //Array cardDeck = CardDeck();
            //foreach (var item in cardDeck)
            //{
            //    Console.WriteLine(item.ToString());
            //}
        }
    }
}
