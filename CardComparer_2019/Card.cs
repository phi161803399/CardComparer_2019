using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardComparer_2019
{
    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public string Name
        {
            get
            {
                return $"{Value.ToString()} of {Suit.ToString()}"; 
            }
        }
    }

    public class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value < y.Value)
                return -1;
            else if (x.Value > y.Value)
                return 1;
            else
                return 0;
        }
    }
}
