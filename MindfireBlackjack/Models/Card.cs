using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MindfireBlackjack.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Suit { get; set; }
        public string Value { get; set; }
        public bool FaceDown { get; set; } = false;

        public string CardName
        {
            get
            {
                return Value + Suit;
            }
        }


    }
}
