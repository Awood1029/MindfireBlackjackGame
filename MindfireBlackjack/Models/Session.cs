using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindfireBlackjack.Models
{
    public class Session
    {
        public int Id { get; set; }
        public List<Player> Players { get; set; }
        public Dealer dealer { get; set; }

        public Session()
        {
            Players = new List<Player>();
            dealer = new Dealer();
            Player player1 = new Player();

            Players.Add(dealer);
            Players.Add(player1);
        }
    }
}
