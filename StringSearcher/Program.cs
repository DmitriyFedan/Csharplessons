using SearchInString;

var searcher = new StringSearcher();
searcher.MyEvent += Handler;  // подписка

List<string> exampleList = new List<string>() {"QWER", "qwer", "REWQ", "1234", "rewq", "123qwer", "REWQ4321" };


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
    Console.WriteLine($"Результаты поиска: {inputstring}");
}


