using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MareDemo
{
    class Rational
    {
        public float Numitor;
        public float Numarator;
        public Rational();
        
        public Rational(float numarator)
        {
            Numarator = numarator;
        }
        public Rational(float numarator, float numitor)
        {
            Numitor = numitor;
            Numarator = numarator;
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.Numarator * r2.Numarator, r1.Numitor * r2.Numitor);
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            return new Rational(r1.Numarator * r2.Numitor + r2.Numarator * r1.Numitor, r1.Numitor * r2.Numitor);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            return new Rational(r1.Numarator * r2.Numitor, r1.Numitor * r2.Numarator);
        }
        
        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational(r1.Numarator * r2.Numitor - r2.Numarator * r1.Numitor, r1.Numitor * r2.Numitor);
        }
        public static Rational operator ^(Rational r, int n)
        {
            Rational power = r;
            while (n > 1) 
            {
                power *= r;
                n--;
            }
            return power;
        }
        public override string ToString()
        {
            return Numarator + "/" + Numitor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rational r1 = new Rational(1, 4);
            Rational r2 = new Rational(2, 4);

            Rational produs = r1 * r2;
            Rational impartire = r1 / r2;
            Rational suma = r1 + r2;
            Rational dif= r1 - r2;
            Rational putere = r1 ^ 2;

            Console.WriteLine(produs);
            Console.WriteLine(impartire);
            Console.WriteLine(suma);
            Console.WriteLine(dif);
            Console.WriteLine(putere);
            Console.ReadLine();
        }
    }
}
