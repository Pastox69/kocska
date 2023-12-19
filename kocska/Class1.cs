using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Negyszog
{
    public class NegyszogClass
    {
        private double
            a, b,
            kerulet,
            terulet;

        public NegyszogClass() { }
        public NegyszogClass(double a) { this.a = a; }
        public NegyszogClass(double a, double b) { this.a = a; this.b = b; }

        public void SetOldal1(double a)
        {
            this.a = a;
        }

        public void SetOldal2(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void SetTerulet()
        {
            this.terulet = a * b;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * (a + b);
        }
        public double getKerulet()
        {
            return this.kerulet;
        }

        public double getTerulet()
        {
            return this.terulet;
        }

    }
}