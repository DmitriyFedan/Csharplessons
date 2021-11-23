
using PolygonPerimetr;

// произвольный Прямоуголник 
Point p1 = new Point("A", 0, 0);
Point p2 = new Point("B", 0, 0);
Point p3 = new Point("C", 4, 3);
Point p4 = new Point("D", 4, 1);

Polygon rect1 = new Polygon(p1, p2, p3, p4);

rect1.PolygonInfo();

double per = rect1.Perimetr();

Console.WriteLine(per);