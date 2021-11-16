

int[] array = new int[8] { 1, 3, 5, 9, 4, 8, 1, 9 };

int maxVal = array[0];
int secondMaxVal = array[0];
foreach (int item in array)
{
    if (item > maxVal) // ищем наибольший 
    {
        secondMaxVal = maxVal;
        maxVal = item;
    }
    else if (item > secondMaxVal && item < maxVal) // проверяем лежит ли текущий в диапазоне от наибольшего до второго наибольшего
    {
        secondMaxVal = item;
    }
}
Console.WriteLine($"Второй по наибольший элемент массива = {secondMaxVal}") ;