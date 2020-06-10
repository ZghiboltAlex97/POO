using System;

namespace Playing_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card(rank.ace, suit.spade);
            Console.WriteLine(c);
            Console.ReadLine();
        }
        public enum suit
        {
            spade, heart, diamond, club
        }
        public enum rank
        {
            ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king
        }

        public class Card
        {
            private readonly rank Rank;
            private readonly suit Suit;
            public Card(rank Rank, suit Suit)
            {
                this.Rank = Rank;
                this.Suit = Suit;
            }
            public override string ToString()
            {
                return "Card: " + Rank + " of " + Suit;
            }

        }
    }
}
