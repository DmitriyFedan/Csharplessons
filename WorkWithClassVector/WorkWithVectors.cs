using WorkWithClassVector;


// создаем  разные вектора для  првоерки работы
Vector vect_1 = new Vector(2, 3, 5);   
Vector vect_2 = new Vector(8, 13, 21);

//Vector vect_1 = new Vector(-5, 3, -8);
//Vector vect_2 = new Vector(8, -13, 21);

//Vector vect_1 = new Vector(0, 3, 0);
//Vector vect_2 = new Vector(8, 0, 21);

// смотрим информацию строковом формате о конкретном векторе
Console.WriteLine(Vector.StringInfo(vect_1)); 
Console.WriteLine(Vector.StringInfo(vect_2));

// смотрим длины векторв 
Console.WriteLine($"Длинна вектора vect_1 = {Vector.VectorLength(vect_1)}");
Console.WriteLine($"Длинна вектора vect_2  = {Vector.VectorLength(vect_2)}");
Console.WriteLine("");

// считаем скалярное проивзедение двух векторов 
double value = Vector.ScalarProduct(vect_1, vect_2);
Console.WriteLine($"Скалярное произведение векторов vect_1 и ect_2 = {value}");
Console.WriteLine("");

// векторное произведение 
Vector vect_3 = Vector.VectorProduct(vect_1, vect_2);
Console.WriteLine($"Тип данных значения полученного при " +
                    $"векторном произведении vect_1 и vect_2: {vect_3.GetType()}");

Console.WriteLine(Vector.StringInfo(vect_3)); // смотрим его координаты

// угол между двумя векторами
double angle_v1_v2 = Vector.AngleAmongVectors(vect_1, vect_2);
Console.WriteLine($"Cos угла между векторами vect_1 и vect_2 = {angle_v1_v2}");

double angle_v2_v3 = Vector.AngleAmongVectors(vect_2, vect_3);
Console.WriteLine($"Cos угла между векторами vect_2 и vect_3 = {angle_v2_v3}");

double angle_v1_v3 = Vector.AngleAmongVectors(vect_1, vect_3);
Console.WriteLine($"Cos угла между векторами vect_1 и vect_3 = {angle_v1_v3}");

// сумма разность 

var vect_4 = Vector.SumVectors(vect_1, vect_2);
Console.WriteLine($"Тип данных значения полученного при " +
                    $"сложении  vect_1 и vect_2: {vect_4.GetType()}");
Console.WriteLine(Vector.StringInfo(vect_4)); // смотрим его координаты

var vect_5 = Vector.DiffVectors(vect_1, vect_2);
Console.WriteLine($"Тип данных значения полученного от " +
                    $"разности  vect_4 и vect_3: {vect_5.GetType()}");
Console.WriteLine(Vector.StringInfo(vect_5)); // смотрим его координаты


