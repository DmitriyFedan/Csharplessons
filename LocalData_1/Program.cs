using System.IO;
using System.IO.Compression;

try
{
    string dirPath = @"G:\WORKED\C# projects\Csharplessons\LocalData_1";
    string zipName = "Homework12.zip";
    //  формируем путь к архиву пробуя Path
    string zipFullPath = Path.Combine(dirPath, zipName);

    string pathExtract = dirPath;

    //  путь файла для записи информации
    string infoFileName = "InfoFile.csv";
    string infoFilePath = Path.Combine(dirPath, infoFileName);
    // путь файла для записи пути к файлу в который записывали информацию
    string fileWithPathFor_infoFilename = Path.Combine(dirPath, "Lesson12Homework.txt");

    if (File.Exists(zipFullPath))
    {
        ZipFile.ExtractToDirectory(zipFullPath, pathExtract);
        //string foldername = Path.GetDirectoryName();

        string pathFinalyDir = Path.Combine(dirPath, "Homework12");    /// т.к архив содержит одноименную папку ,
        //можно ли  как то сразу вернуть имя данной папки
        //содержащейся в извлекаемой директории?

        if (Directory.Exists(pathFinalyDir)) ;
        {
            DirectoryInfo dirinfo = new DirectoryInfo(pathFinalyDir);
            FileInfo fileInfo = new FileInfo(pathFinalyDir);

            foreach (var item in dirinfo.GetDirectories())
            {
                //Console.WriteLine(item.Name);
                // формируем то то что нужно записывать
                string writablevalue = $"Папка: {item.Name},  дата изменения: {Directory.GetLastWriteTime(item.FullName)}";
                FileWriteInfo(infoFilePath, writablevalue);
            }
            foreach (var item in dirinfo.GetFiles())
            {
                //Console.WriteLine(item.Name);
                // формируем то то что нужно записывать
                string writablevalue = $"Файл: {item.Name},  дата измениния: {File.GetLastWriteTime(item.FullName)}";
                FileWriteInfo(infoFilePath, writablevalue);
            }
            Directory.Delete(pathFinalyDir, true);
            //Console.WriteLine("Файл удален");
            FileWriteInfo(fileWithPathFor_infoFilename, infoFilePath);

        }

        static void FileWriteInfo(string path, string writableValue)
        {
            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                sw.WriteLine($"{writableValue}\t");
        }

    }
}
catch (Exception ex)
{

    Console.WriteLine($"Непредвиденная ошибка {ex.Message}");
}

