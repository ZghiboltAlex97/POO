using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPoint
{
    public class Point : AbstractPoint
    {
        private float ab;
        private float ac;
        private float ad;
        private float AF;
        public override float a
        {
            get { return ab; }
            set { ab = value; ad = rGet(); AF = AGet(); }
        }
        public override float b
        {
            get { return ac; }
            set { ac = value; ad = rGet(); AF = AGet(); }
        }
        public override float r
        {
            get { return ad; }
            set { ad = value; ab = aGet(); ac = bGet(); }
        }
        public override float A
        {
            get { return AF; }
            set { AF = value; ab = aGet(); ac = bGet(); }
        }
        public Point(PointRepresentation pr, float ar, float bA)
        {
            if (pr == PointRepresentation.Polar)
            {
                ad = ar;
                AF = bA;
                ab = aGet();
                ac = bGet();
            }
            if (pr == PointRepresentation.Rectangular)
            {
                ab = ar;
                ac = bA;
                ad = rGet();
                AF = AGet();
            }
        }
        public override void Move(float x, float y)
        {
            ab += x;
            ac += y;
            ad = rGet();
            AF = AGet();
        }
        public override void Rotate(float angle)
        {
            AF += angle;
            ab = aGet();
            ac = bGet();
        }
    }
}