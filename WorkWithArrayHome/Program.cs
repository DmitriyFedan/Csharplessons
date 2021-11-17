
while (true)
{
    Console.Clear();
    Console.WriteLine("==      Ищем второй наибольший элемент массива      == ");
    Console.Write("Введите число элементов  предполагаемого массива: ");
    int count;
    try
    {
        if (!int.TryParse(Console.ReadLine(), out count)) // на случай если вводят не число
        {
            Console.WriteLine("Не удалось преобразовать введенное значение в целое число");
            Console.WriteLine("Нажмите любую клавишу чтобы начать с начала");
            Console.ReadKey();
            continue;
        }
        if (count < 2)  // на случай  пытаются искать в массиве в котором мене 2 элентов
        {
            Console.WriteLine("В массиве менее 2 элементов");
            Console.WriteLine("Нажмите любую клавишу чтобы начать с начала");
            Console.ReadKey();
            continue;
        }
        //int count = Convert.ToInt32(Console.ReadLine()); // тут может быть ex 
        int[] user_array = new int[count] ;
        for (int i=0; i<= user_array.Length; i++)
        {
            Console.Clear();
            Console.WriteLine("==      Ищем второй наибольший элемент массива      == ");
            Console.Write("Ваш массив: ");
            foreach (int item in user_array)
                Console.Write($"{item} ");
            Console.WriteLine("\n");
            if (i == user_array.Length) break; // пока что оставлю костыль тут,(для полногоотображения введенного массива )
            Console.Write("Вводите элементы массива целыми числами, по одному: ");
           // user_array[i] = Convert.ToInt32(Console.ReadLine()); //   тут может быть ex 
            if (!int.TryParse(Console.ReadLine(), out user_array[i]))  // на случай  если пытаются добавлять  не цифры
            {
                i--;
                Console.WriteLine("не удалось преобразовать ввод в цифру");
                Console.WriteLine("Нажмите любую клавишу повторить ввод текущего элемента");
                Console.ReadKey();
                continue;
            }  
        }    
        int result = SearchInArr(user_array); 
        Console.WriteLine($"Второй по наибольший элемент массива = {result}");
        Console.WriteLine("Нажмите любую клавишу чтобы начать с начала");
        Console.ReadKey();
    }
    catch(Exception ex) /// на случай тех ошибок что я не смог предусмотреть
    {
        Console.WriteLine("Возникла  неизвестная ошибка");
        Console.WriteLine(ex.Message);
        Console.WriteLine("Нажмите любую клавишу чтобы начать с начала");
        Console.ReadKey();
        Console.Clear();
        continue;
    }
}

static int SearchInArr(int[] array)   // сам метод поиска  в массиве
{
    int maxVal = array[0];
    int secondMaxVal = array[0];
    foreach (int item in array)
    {
        if (item > maxVal) //  если есть новый макс. старый  записываем во второй макс 
        {
            secondMaxVal = maxVal;
            maxVal = item;
        }
        else if (item > secondMaxVal && item < maxVal) // проверяем лежит ли текущий в диапазоне от наибольшего до второго наибольшего
        {
            secondMaxVal = item;
        }
    }
    if (maxVal == secondMaxVal) // если все элементы одинвковые 
        throw new Exception(" В массиве невозможно найти второй максималньый элемент"); 
    return secondMaxVal;
}
