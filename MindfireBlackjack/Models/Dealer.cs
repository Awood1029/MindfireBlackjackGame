using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindfireBlackjack.Models
{
    public class Dealer : Player
    {
        public Deck Deck { get; set; }


        public Dealer()
        {
            IsDealer = true;
            Deck = new Deck();
        }

        public object Deal(List<Player> players)
        {
            foreach(Player player in players)
            {
                for(int count = 0; count < 2; count++)
                {
                    player.Hand.Add(Deck.DrawCard());
                }

                if(player.IsDealer)
                {
                    Hand.First().FaceDown = true;
                }

            }
            return null;
        }

    }
}
