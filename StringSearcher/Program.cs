using SearchInString;

try
{
    var searcher = new StringSearcher();
    searcher.MyEvent += Handler;  // подписка

    List<string> exampleList = new List<string>() { "QWER", "qwer", "REWQ", "1234", "rewq", "123qwer", "REWQ4321" };


    string exampleString = "qwe";
    //string exampleString = "123";
    //string exampleString = "vbn";
    //string exampleString = "EWQ";

    searcher.Search(exampleList, exampleString);

    searcher.MyEvent -= Handler;  // отписка
                                  //пробуем еще раз
    searcher.Search(exampleList, exampleString);

    static void Handler(string inputstring)
    {
        Console.WriteLine($"Искомая строка содержится в : {inputstring}");
        //searcher.MyEvent -= Handler; не совсем понял что значит
        //возможность отмены дальнейшей генерации событий в обработчике
        // но похоже это должно происходить здесь
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Что то пошло не по плану, а именно {ex.Message}");
}



