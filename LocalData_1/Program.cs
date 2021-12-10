using System.IO;
using System.IO.Compression;

string dirPath = @"G:\WORKED\C# projects\Csharplessons\LocalData_1";
string fileName = "Homework12.zip";
string zipFullPath = Path.Combine(dirPath, fileName);

string pathExtract = dirPath;


string infoFileName = "InfoFile.csv";
string infoFilePath = Path.Combine(dirPath, infoFileName);

string fileWithPathFor_infoFilename = Path.Combine(dirPath, "Lesson12Homework.txt");

if (File.Exists(zipFullPath))
{
    ZipFile.ExtractToDirectory(zipFullPath, pathExtract);
    //string foldername = Path.GetDirectoryName();

    string pathFinalyDir = Path.Combine(dirPath, "Homework12");    /// т.к архив содержит одноименную папку ,
                                                                  //можно ли  как то сразу вернуть имя данной папки
                                                                  //содержащейся в извлекаемой директории?
                                                                  
    if (Directory.Exists(pathFinalyDir ));
    {
        DirectoryInfo dirinfo = new DirectoryInfo(pathFinalyDir);
        FileInfo fileInfo = new FileInfo(pathFinalyDir);

        foreach (var item in dirinfo.GetDirectories())
        {
            //Console.WriteLine(item.Name);
            FileWriteInfo(infoFilePath, item.Name); //Console.WriteLine()
            
        }
        foreach (var item in dirinfo.GetFiles())
        {
            //Console.WriteLine(item.Name);
            FileWriteInfo(infoFilePath, item.Name);
        }
        Directory.Delete(pathFinalyDir,true);
        
    }

    static void FileWriteInfo(string path, string info)
    {
        using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            sw.WriteLine($"{info}\t");
    }

    


}
