namespace WorkWith3dFigures
{
    public class Ball : Shape
    {
        public double R { get; }
        public Ball(double radius)
        {
            R = radius;
        }
        public override double Volume()
        {
            double volume = 4 / 3 * Pi * Math.Pow(R, 3);
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