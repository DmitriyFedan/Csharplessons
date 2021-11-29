namespace WorkWith3dFigures
{
    public class Cylinder : Shape
    {
        public double H {get;}
        public double R {get;}
        public double SBase
        {
            get
            {
                return Pi * Math.Pow(R, 2);
            }
        }
        public Cylinder( double height, double baseRadius)
        { 
            R = baseRadius;
            H = height;
            
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