using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindfireBlackjack.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public List<Card> Cards = new List<Card>(); 
        public enum Suits { Hearts, Diamonds, Clubs, Spades }
        private static readonly Random RandomNumberGenerator = new Random();
        private static readonly object SyncLock = new object();

        public int RandomNumber(int min, int max)
        {
            lock (SyncLock)
            {
                return RandomNumberGenerator.Next(min, max);
            }
        }

        public Deck()
        {
            for(int count = 1; count <= 13; count++)
            {
                for(int suitCounter = 0; suitCounter < 4; suitCounter++)
                {
                    string suit = "";

                    switch(suitCounter)
                    {
                        case 0: suit = "H";
                            break;
                        case 1:
                            suit = "D";
                            break;
                        case 2:
                            suit = "S";
                            break;
                        case 3:
                            suit = "C";
                            break;
                    }

                    Card card = new Card();
                    card.Suit = suit;
                    switch(count)
                    {
                        case 1: card.Value = "A";
                            break;
                        case 11: card.Value = "J";
                            break;
                        case 12: card.Value = "Q";
                            break;
                        case 13: card.Value = "K";
                            break;
                        default: card.Value = count.ToString();
                            break;
                    }

                    Cards.Add(card);

                }
            }
        }

        public Card DrawCard()
        {
            int index = RandomNumber(1, Cards.Count - 1);
            Card card = Cards.ElementAt(index);
            Cards.RemoveAt(index);

            return card;
        }
    }
}
