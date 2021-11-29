using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Observer2
{
    public class BovespaPaper : Investiment
    {
        public BovespaPaper(string simbol, decimal value) : base(simbol, value)
        {
        }
    }
}
