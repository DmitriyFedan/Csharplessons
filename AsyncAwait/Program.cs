
using System.Threading.Tasks;
using System.Threading;
//using System.IO;
using System.Text;


try
{
    static async void FileReaderAsync(string FilePath, CancellationToken token)
    {

        if (File.Exists(FilePath))
        {
            Console.WriteLine("Начало считывания файла");

            using (StreamReader reader = new StreamReader(FilePath))
            {
                StringBuilder builder = new StringBuilder();
                int stringcounter = 1;
                while (!reader.EndOfStream)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Операция считывания прервана пользователем");
                        return;
                    }
                    await Task.Run(() =>
                    {
                        builder.Append(reader.ReadLine());
                        //Thread.Sleep(10000);
                        Console.WriteLine($"Считано {stringcounter} строк");
                        stringcounter += 1;
                    });
                }
                Console.WriteLine("Считывание завершено");
                //string result = builder.ToString(); ///  если  нужен в виде  строки 
            }
        }
        else Console.WriteLine($"Не удалось найти файл по указанному пути {FilePath}");
    }



    //FileReaderBreaker();

    string dirPath = @"G:\WORKED\C# projects\Csharplessons\AsyncAwait";
    string fileName = "3.json";
    string filePath = Path.Combine(dirPath, fileName);


    CancellationTokenSource cts = new CancellationTokenSource();
    CancellationToken token = cts.Token;

    
    
    FileReaderAsync(filePath, token); /// метод 


    void FileReaderBreaker()
    {
        Console.WriteLine("Для прерывания считывания файла нажмите x");

        ConsoleKeyInfo key = Console.ReadKey();
        if (key.KeyChar == 'x')
        {
            cts.Cancel();   // 
            Console.WriteLine(" отмена");
        }
        else FileReaderBreaker(); // на тот случай если в первый раз по ошибке ввели другой символ,
                                   // хотя навернеое проще было сделать через простой цикл
    }
    FileReaderBreaker();
    Console.Read(); // ожидаем
}
catch (Exception ex)
{
    Console.WriteLine($"Возникла неизвестная ошибка {ex.Message}");//
}


