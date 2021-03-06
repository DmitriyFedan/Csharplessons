using WorkWith3dFigures;


try
{
    Console.WriteLine("ТЕСТ");
    Box box1 = new Box(10);
    double box1_vol = box1.Volume();

   
    Box box2 = new Box(6);
    double box2_vol = box2.Volume();


    Cylinder cyl1 = new Cylinder(5, 2.5);
    double cyl1_vol = cyl1.Volume();

    Pyramid pyr1 = new Pyramid(13, 21);
    double pyr1_vol = pyr1.Volume();

    Ball ball1 = new Ball(5);
    double ball1_vol = ball1.Volume();

    Console.WriteLine($"Объем Куба {box1_vol} \n" +
                      $"Объем кубика {box2_vol}\n " +
                      $"Объем Цилиндра {cyl1_vol} \n" +
                      $"Объем Пирамиды {pyr1_vol} \n" +
                      $"Объем Сферы {ball1_vol}");


    // наполняем коробку разными фигурами и смотрим что содержится
    if (box1.Add(cyl1)) Console.WriteLine(box1.PrintInfo());
    else Console.WriteLine($"Не удалось добавить фигуру {box1.PrintInfo()}");
    
    if (box1.Add(pyr1)) Console.WriteLine(box1.PrintInfo());
    else Console.WriteLine($"Не удалось добавить фигуру {box1.PrintInfo()}");
    
    if (box1.Add(box2)) Console.WriteLine(box1.PrintInfo());
    else Console.WriteLine($"Не удалось добавить фигуру {box1.PrintInfo()}");

    if (box1.Add(ball1)) Console.WriteLine(box1.PrintInfo());
    else Console.WriteLine($"Не удалось добавить фигуру {box1.PrintInfo()}");

    if (box1.Add(ball1)) Console.WriteLine(box1.PrintInfo());
    else Console.WriteLine($"Не удалось добавить фигуру {box1.PrintInfo()}");
   
    if (box1.Add(ball1)) Console.WriteLine(box1.PrintInfo());
    else Console.WriteLine($"Не удалось добавить фигуру {box1.PrintInfo()}");
    //  тут уже не хватит места для следующей 
    if (box1.Add(ball1)) Console.WriteLine(box1.PrintInfo());
    else Console.WriteLine($"Не удалось добавить фигуру {box1.PrintInfo()}");
    box1.PrintInfo();
}
catch (Exception ex)
{ 
    Console.WriteLine($"Возникла неизвестная ошибка {ex.Message}");
}