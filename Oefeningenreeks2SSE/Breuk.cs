using System;
using System.Collections.Generic;
using System.Text;

namespace Oefeningenreeks2SSE
{
    class Breuk
    {
        public int Teller { get; set; }
        public int Noemer { get; set; }

        public Breuk(int teller, int noemer) {
            this.Teller = teller;
            this.Noemer = noemer;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static Breuk operator + (Breuk a, Breuk b)
        {
            return new Breuk(a.Teller + b.Teller, a.Noemer + b.Noemer);
        }

        public static Breuk operator -(Breuk a, Breuk b)
        {
            return new Breuk(a.Teller - b.Teller, a.Noemer - b.Noemer);
        }

        public static Breuk operator *(Breuk a, Breuk b)
        {
            return new Breuk(a.Teller * b.Teller, a.Noemer * b.Noemer);
        }

        public static Breuk operator /(Breuk a, Breuk b)
        {
            return new Breuk(a.Teller * b.Noemer, a.Noemer + a.Teller);
        }
        /*
        public static bool operator ==(Breuk a, Breuk b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Breuk a, Breuk b)
        {
            return ! a.Equals(b);
        }
        */
        public static bool operator > (Breuk a, Breuk b)
        {
            return a.Noemer > b.Noemer && a.Teller > b.Teller;
        }

        public static bool operator < (Breuk a, Breuk b)
        {
            return a.Noemer < b.Noemer && a.Teller < b.Teller;
        }
    }
}

