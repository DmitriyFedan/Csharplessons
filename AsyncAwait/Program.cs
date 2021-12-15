
using System.Threading.Tasks;
using System.Threading;
//using System.IO;


static async void FileReaderAsync()
{
    string filePath = @"G:\WORKED\C# projects\Csharplessons\AsyncAwait\Test.txt";
    if (File.Exists(filePath))
    {
        Console.WriteLine("Начало считывания файла");
        using (StreamReader reader = new StreamReader(filePath))
        {
            string result = await reader.ReadToEndAsync();
            Thread.Sleep(10000);
            Console.WriteLine("Считывание завершено");
            Console.WriteLine($"считали текст: {result}");
        }
    }
    else Console.WriteLine($"Не удалось найти файл по указанному пути {filePath}");
}

static void FileReaderBreaker()
{
    CancellationTokenSource cts = new CancellationTokenSource();
    CancellationToken token = cts.Token;

    Console.WriteLine("Для прерывания считывания файла нажмите X");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine(key.KeyChar);


}
FileReaderAsync();
FileReaderBreaker();

Console.Read();

