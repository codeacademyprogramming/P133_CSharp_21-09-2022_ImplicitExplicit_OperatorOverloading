using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitExplicit.Models
{
    class Manat
    {
        public double AZN;

        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar { USD = manat.AZN / 1.71 };
        }
    }
}
