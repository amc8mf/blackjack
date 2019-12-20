using System;

namespace CardGameLibrary
{
    class Program
    {
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
            int sequenceNum;
            public Card(String displayName, String suit, int sequenceNum, int value)
            {
                this.displayName = displayName;
                this.suit = suit;
                this.sequenceNum = value;
                this.value = value;
            }
            public string getName()
            {
                return displayName;
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

        public class Player
        {
            String turn;
            int totalChips;
            int currentBet;
        }
        static void Main(string[] args)
        {
            Card[] myDeck = new Card[51];
            int sequenceNum = 1;
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (int i = 2; i <= 14; i++)
                    {
                    myDeck[i] = new Card(GetDisplayName(i, suit), suit.ToString(), sequenceNum, i);
                    sequenceNum += 1;
                    Console.WriteLine(myDeck[i].getName());
                }
                
            }

            static string GetDisplayName(int value, Suit suit)
                {
                    String valueString = "";
                    if (value >=2 && value <= 10)
                    {
                        valueString = value.ToString();
                    }
                    else if (value == 11)
                    {
                        valueString = "Jack";
                    }
                    else if (value == 12)
                    {
                        valueString = "Queen";
                    }
                    else if (value == 13)
                    {
                        valueString = "King";
                    }
                    else if (value == 14)
                    {
                        valueString = "Ace";
                    }
                    return valueString + " of " + suit;
                }
        }
    }
}
