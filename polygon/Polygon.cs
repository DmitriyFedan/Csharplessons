using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolygonPerimetr;

namespace PolygonPerimetr
{
    public class Polygon
    {
        // для  хранения точек при создании экземпляра(стартовое знач Capacity3)
        private List<Point> polygonPoints = new List<Point>(3);
        public string PolygonName { get;}


        public Polygon(Point p1, Point p2, Point p3)
        {
            polygonPoints.AddRange(new Point[] { p1, p2, p3 });
            PolygonName = $"треугольник {p1.Name}{p2.Name}{p3.Name}";
        }
        public Polygon(Point p1, Point p2, Point p3, Point p4)
        {
            polygonPoints.AddRange(new Point[] { p1, p2, p3, p4 });
            PolygonName = $"четырехугольник {p1.Name}{p2.Name}{p3.Name}{p4.Name}";
        }
        public Polygon(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            polygonPoints.AddRange(new Point[] { p1, p2, p3, p4, p5});
            PolygonName = $"пятиугольник {p1.Name}{p2.Name}{p3.Name}{p4.Name}{p5.Name}";
        }

        public double Perimetr()
        {
            //int errorvalue = 0;
            double result = 0;
            for (int i = 1; i < polygonPoints.Count ; i++)
            {
                result += SideLenght(polygonPoints[i-1], polygonPoints[i]);
            }
            // нужно  найти длинну последней стороны (м-у первой и последней точкой)
            result += SideLenght(polygonPoints[polygonPoints.Count - 1], polygonPoints[0]);
            return Math.Round(result,2);  //  округилим до 2 знаков после запятой

            /*if (length <= 0)
                    errorvalue += 1;   (нужно добавить обработку если все  точки на одной прямой)
                 проверить углы межды сторонами если угол 180 между всеми сторонами*/
            //  или  проверить колинеарность  сторон (принимая их за векторы)
        }

        public double SideLenght(Point p1, Point p2)
        {
            double sidelenght = Math.Pow((p1.X - p2.X), 2) +
                                Math.Pow((p1.Y - p2.Y), 2);
            sidelenght = Math.Sqrt(sidelenght);
            return sidelenght;
        }
        public void PolygonInfo()
        {
            Console.WriteLine($"{PolygonName} периметр равен {Perimetr()}");
        }
    }
}
