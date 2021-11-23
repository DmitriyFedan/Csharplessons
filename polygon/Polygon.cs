using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolygonPerimetr;

namespace PolygonPerimetr
{
    internal class Polygon
    {
        // для  хранения точек при создании экземпляра(стартовое знач Capacity3)
        private List<Point> polygonPoints = new List<Point>(3);


        public Polygon(Point p1, Point p2, Point p3)
        {
            polygonPoints.AddRange(new Point[] { p1, p2, p3 });
        }
        public Polygon(Point p1, Point p2, Point p3, Point p4)
        {
            polygonPoints.AddRange(new Point[] { p1, p2, p3, p4 });
        }
        public Polygon(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            polygonPoints.AddRange(new Point[] { p1, p2, p3, p4, p5});
        }

        public int Perimetr()
        {
            int result = 0;
            for (int i = 0; i < polygonPoints.Count; i++ )
            {
               double  sideLength =  Math.Pow((polygonPoints[i].X - polygonPoints[i-1].X), 2) + 
                                     Math.Pow((polygonPoints[i].Y - polygonPoints[i-1].Y), 2);
            }
            
            
            
            return result;
        }

    }
}
