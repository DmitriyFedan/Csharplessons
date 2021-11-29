namespace WorkWith3dFigures
{
    public class Box : Shape
    {
        public double H { get; }
        public double ResidualCapacity { get; private set; }
        private List<Shape> InBox = new List<Shape>();   // список содержащихся деталей

        public Box(int height)
        {
            H = height;
            ResidualCapacity = Volume(); // посчитаем свободный объем при  создании экземпляра класса
        }
        public override double Volume()
        {
            double volume = Math.Pow(H, 3);
            return Math.Round(volume, 2);
        }

        public bool Add(Shape shape)
        {
            if (ResidualCapacity >= shape.Volume())
            {
                ResidualCapacity -= shape.Volume();
                InBox.Add(shape);
                return true;
            }
            else
                
                return false;
        }
        public string PrintInfo()
        {
            // string listfigures = String.Join(" ", InBox.ToString());   /// проверить работает ли это( не работает)
            string? listfigures = null;
            foreach (Shape shape in InBox)
            {
                //listfigures = String.Concat(listfigures,(Convert.ToString(GetType().Name)));/ не  так работает 
                listfigures = $"{listfigures} {(Convert.ToString(shape.GetType().Name))}";  // вроде рабоатет
            }


            string info = $"В боксе: {listfigures}. Cвободный объем {Math.Round(ResidualCapacity, 2)}";
            return info;
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