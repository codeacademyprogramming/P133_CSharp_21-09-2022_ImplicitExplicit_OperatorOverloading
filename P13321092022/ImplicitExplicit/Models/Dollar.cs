using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitExplicit.Models
{
    class Dollar
    {
        public double USD;

        public static explicit operator Manat(Dollar dollar)
        {
            return new Manat { AZN = dollar.USD * 1.69 };
        }
    }
}
