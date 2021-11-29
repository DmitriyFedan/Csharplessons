namespace WorkWith3dFigures
{
    public class Cylinder : Shape
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
            //double volume = Pi * (Math.Pow(R, 2)) * H;    //
            double volume = SBase * H;
            return Math.Round(volume, 2);
        }
    }
}


/// попробовать  реализовать иерархию наследования 
///       box : shape       //  piramida : box
///       ball: shape       // cylinder : ball 
///  
///    иил cylynder: piramida
///    посотреть как при этом себя ведет   абстрактный метод Volume 
///  