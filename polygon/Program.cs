
using PolygonPerimetr;

try
{
    // произвольный четырехугольник 
    Point p1 = new Point("A", 0, 0);
    Point p2 = new Point("B", 0, 0);
    Point p3 = new Point("C", 4, 3);
    Point p4 = new Point("D", 4, 1);

    Polygon rect1 = new Polygon(p1, p2, p3, p4);

    rect1.PolygonInfo();   // смотрим информацию  о  многоугольнике (имя и периметр)
    double per = rect1.Perimetr(); 
    Console.WriteLine(per);     // получаем только периметр()

    // произвольный четырехугольник
    // (добавить проверку  если  точки на одной прямой или все нули )
    Point p1_2 = new Point("A", 0, 0);
    Point p2_2 = new Point("B", 0, 0);
    Point p3_2 = new Point("C", 4, 3);
    Point p4_2 = new Point("D", 4, 1);

    Polygon rect2 = new Polygon(p1_2, p2_2, p3_2, p4_2);
    rect2.PolygonInfo();
    Console.WriteLine(rect2.Perimetr());

    // произвольный треугольник 
    Point p1_3 = new Point("A", 0, 0);
    Point p2_3 = new Point("B", 1, 0);
    Point p3_3 = new Point("C", 4, 3);
   

    Polygon triangle = new Polygon(p1_3, p2_3, p3_3);
    triangle.PolygonInfo();
    Console.WriteLine(triangle.Perimetr());

    // произвольный пятиугольник 
    Point p1_4 = new Point("A", 0, 0);
    Point p2_4 = new Point("B", 1, 0);
    Point p3_4 = new Point("C", 4, 3);
    Point p4_4 = new Point("D", 4, 1);
    Point p5_4 = new Point("E", 3, 0);

    Polygon pentagon = new Polygon(p1_4, p2_4, p3_4, p4_4, p5_4);
    pentagon.PolygonInfo();
    Console.WriteLine(pentagon.Perimetr());
}

catch (Exception ex)
{ 
    Console.WriteLine($"Возникла непредвиденная ошибка{ex.Message}");
}


