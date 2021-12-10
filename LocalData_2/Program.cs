
try
{
    string dirpath = @"G:\WORKED\C# projects\Csharplessons\LocalData_2";

    string dirwithReadableFile = @"G:\WORKED\C# projects\Csharplessons\LocalData_1\";
    string readableFileName = "Lesson12Homework.txt";

    string readableFilePath = Path.Combine(dirwithReadableFile, readableFileName);

    string? finalyPath = null;  // сюда будет записан путь к csv файлу 
    if (File.Exists(readableFilePath))


        using (StreamReader st = new StreamReader(readableFilePath, System.Text.Encoding.Default))
        {
            string readablevalue = Path.Combine(st.ReadLine());
            //string readablevalue = Path.Combine(st.ReadToEnd());
            //string readablevalue = st.ReadToEnd();
            //string readablevalue = st.ReadLine();
            //Console.WriteLine(readablevalue);
            string st1 = Path.Combine(@"G:\WORKED\C# projects\Csharplessons\LocalData_1", "InfoFile.csv");   //   существующий путь
            //string st2 = readablevalue;  // то что считали
            //Console.WriteLine(st1 == st2);   // они абсолютно одинаковые но возвращает False
            //Console.WriteLine(st1.Equals(st2));
            //Console.WriteLine(Path.Combine(@"G:\WORKED\C# projects\Csharplessons\LocalData_1", "InfoFile.csv"));
            //Console.WriteLine((Path.Combine(@"G:\WORKED\C# projects\Csharplessons\LocalData_1", "InfoFile.csv")).Equals(readablevalue));
            // В какой то момент  это перестало работать (причину не смог найти подставил путь напрямую) сначала все работало
            //if (File.Exists(readablevalue))   // перепроверить почему это перестало работать 
            if (File.Exists(Path.Combine(@"G:\WORKED\C# projects\Csharplessons\LocalData_1", "InfoFile.csv")))

                finalyPath = st1; // вставил временно(если вы это увидели то на данный момент проблему решить мне не удалось)
            else
                Console.WriteLine($"Файл по считанному пути{readablevalue} не существует");
            //Console.WriteLine(finalyPath);
        }
    else Console.WriteLine($"файл {readableFilePath}, не удалось обнаружить, дальнейшие дествия не выполнены, проверьте путь");

    if (!String.IsNullOrEmpty(finalyPath))
    {
        //Console.WriteLine(finalyPath);
        ShowFileContentWithDateSort(finalyPath);
    }

    if (File.Exists(readableFilePath))
    { 
        File.Delete(readableFilePath);
    }
    else
    {
        Console.WriteLine($"Файл {readableFilePath}, не найден или удален ранее");
    }

}
catch (Exception ex)
{ Console.WriteLine($"Непредвиденная ошибка {ex.Message}") ; }


static void  ShowFileContentWithDateSort (string filePath)
{
    if (File.Exists(filePath))
    {
        using (StreamReader st = new StreamReader(filePath, System.Text.Encoding.Default))
        {
            string readablevalue = st.ReadLine();
            Console.WriteLine(readablevalue);
            /// пока не придумал как отсортировать по дате изменения (ведь это не директория а просто строки)
        }
    }
    else Console.WriteLine($"Не удалось найти файл {filePath}");
}