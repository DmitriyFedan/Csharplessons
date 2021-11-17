

while (true)
{
    Console.WriteLine("==      Ищем второй наибольший элемент массива      == ");
    Console.Write("Введите число элементов  предполагаемого массива: ");
    try
    {
        int count = Convert.ToInt32(Console.ReadLine()); // тут может быть ex 
        int[] user_array = new int[count] ;
        for (int i=0; i< user_array.Length; i++)
        {
            Console.Clear();
            Console.WriteLine("==      Ищем второй наибольший элемент массива      == ");
            Console.Write("Ваш массив: ");
            foreach (int item in user_array)
                Console.Write($"{item} ");
            Console.WriteLine("\n");
            Console.Write("Вводите элементы массива целыми числами, по одному: ");
            user_array[i] = Convert.ToInt32(Console.ReadLine()); //   тут может быть ex 
        }
        
        int result = SearchInArr(user_array);
        Console.WriteLine($"Второй по наибольший элемент массива = {result}");
    }
    catch
    {
        Console.WriteLine("Возникла ошибка");
        Console.WriteLine("Нажмите любую клавишу чтобы начать с начала");
        Console.ReadKey();
        Console.Clear();
        continue;
    }

}

static int SearchInArr(int[] array)
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
    return secondMaxVal;
}
