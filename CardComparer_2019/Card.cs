﻿using System;
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
}
