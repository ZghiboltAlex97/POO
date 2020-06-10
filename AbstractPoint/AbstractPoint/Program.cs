using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point d1 = new Point(PointRepresentation.Rectangular, 2, 2);
            Point d2 = new Point(PointRepresentation.Polar, 5, 2);
            d1.Move(5,5);
            d1.Rotate(2);
            d2.Move(0, -5);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.ReadKey();
        }
    }
}
