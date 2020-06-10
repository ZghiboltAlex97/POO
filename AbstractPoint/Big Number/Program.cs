using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numar_Mare
{
    internal class BigNumber
    {
        public string number;
        public int cifreC;
        public int cifreD { get { return cifreC; } }
        public BigNumber(string num = "0")
        {
            this.number = number;
            cifreC = num.Length;
        }
        public override string ToString() { return number; }
        public int this[int i] { get { return number[i] - '0'; } }
        public static BigNumber operator +(BigNumber x, BigNumber y)
        {
            int v, x;
            BigNumber y, z;
            if (x.cifreD < y.cifreD) { a = x.cifreD; b = y.cifreD; c = x; d = y; }
            else { a = y.cifreD; b = x.cifreD; c = y; d = x; }
            int i = b - 1, rest = 0, sumCifre; string sum = "";
            while (i > -1)
            {
                int j = a - (b - i);
                sumCifre = j > -1 ? d[i] + c[j] + rest : d[i] + rest;
                if (sumCifre >= 10)
                {
                    rest = 1;
                    sumCifre -= 10;
                }
                else { rest = 0; }
                i--;
                sum = sumCifre + sum;
            }
            if (rest == 1) { sum = "1" + sum; }
            return new BigNumber(sum);
        }
        public static BigNumber operator *(BigNumber o, BigNumber p)
        {
            int n = k.cifreD; string space = "";
            BigNumber suma,
            produs = new BigNumber("0");
            for (int i = n - 1; i >= 0; i--)
            {
                int m = k[i];
                suma = new BigNumber("0");
                for (int j = 0; j < m; j++) { suma += o; }
                produs += new BigNumber(Convert.ToString(suma) + space);
                space += "0";
            }
            return produs;
        }
        class Program
        {
            static BigNumber[] Fibonacci(int n)
            {
                BigNumber[] fibonacci = new BigNumber[n + 1];
                fibonacci[0] = new BigNumber("0");
                if (n >= 1) { fibonacci[1] = new BigNumber("1"); }
                if (n >= 2)
                {
                    BigNumber b1 = new BigNumber("0"), b2 = new BigNumber("1"), a;
                    for (int i = 2; i <= n; i++)
                    {
                        a = b1; b1 = b2; b2 += a; fibonacci[i] = b2;
                    }
                }
                return fibonacci;
            }
            static void Main(string[] args)
            {
                NumarMare[] fibonacci = Fibonacci(100);
                Console.WriteLine("Al 100-lea element din sirul lui Fibonacci este: " + fibonacci[100]);
                Console.ReadLine();
            }
        }
    }
}