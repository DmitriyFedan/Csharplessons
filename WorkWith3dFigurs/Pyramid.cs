namespace WorkWith3dFigures
{
    public class Pyramid : Shape
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