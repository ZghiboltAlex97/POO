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
            Point d1 = new Point(PointRepresentation.Rectangular, 3, 3);
            Point d2 = new Point(PointRepresentation.Polar, 6, 3);
            d1.Move(6,6);
            d1.Rotate(3);
            d2.Move(0, -6);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.ReadKey();
        }
    }
}
