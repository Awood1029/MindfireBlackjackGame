using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindfireBlackjack.Models
{
    public class Player
    {
        public int Id { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();
        public bool IsDealer { get; set; }

        public Player(bool isDealer = false)
        {
            IsDealer = isDealer;
        }

        public string ShowHand()
        {
            string HandDescription = "";
            foreach(Card card in Hand)
            {
                if(card.FaceDown)
                {
                    HandDescription += "** ";
                }
                else
                {
                    HandDescription += card.CardName + " ";
                }
            }
            return HandDescription;
        }

        public object Hit(Deck deck)
        {
            Card card = deck.DrawCard();
            Hand.Add(card);
            return null;
        }

    }
}
