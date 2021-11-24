using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWith3dFigurs
{
    internal abstract class Shape
    {
        public abstract double Volume();
        protected const double Pi = 3.1415;
    }

    internal class Box : Shape
    { 
        public double H { get; }

        public Box(int height)
        {
            H = height;
        }
        public override double Volume()
        {
            double volume = Math.Pow(H, 3);
            return volume;
        }
    }


    internal class Cylinder : Shape
    {
        public double H {get;}
        public double R {get;}
        public double SBase { get; }
        public Cylinder( int height, int baseRadius)
        { 
            R = baseRadius;
            H = height;
            SBase = Pi * Math.Pow(baseRadius, 2);
        }
        public override double Volume()
        {
            //double volume = Pi * (Math.Pow(R, 2)) * H;    // не понял зачем дано две формулы()
            double volume = SBase * H;
            return volume;
        }
    }


    internal class Pyramid : Shape
    {
        public double SBase { get; init; }
        public double H { get; init; }
        public Pyramid(double height, double SBase)
        {
            H = height;
            this.SBase = SBase;
        }

        public override double Volume()
        {
            double volume = (SBase * H) / 3;
            return volume;
        }
    }


    internal class Ball : Shape
    {
        public double R { get; }
        public Ball(double radius)
        {
            R = radius;
        }
        public override double Volume()
        {
            double volume = 4 / 3 * Pi * Math.Pow(R, 3);
            return volume; 
        }
    }
}
