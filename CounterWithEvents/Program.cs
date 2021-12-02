using CounterWithEvents;

try
{
    Counter myCounter = new Counter(77);

    Handler1 handler1 = new Handler1();
    Handler2 handler2 = new Handler2();
    // добавление двух подписок
    myCounter.MyEvent += handler1.GetMessage; 
    //myCounter.MyEvent += handler2.GetMessage;

    myCounter.Count();
    // одна отписка от события
   // myCounter.MyEvent -= handler2.GetMessage;
    myCounter.Count();
}
catch (Exception ex)
{
    Console.WriteLine($"Возникла неизвестная ошибка {ex.Message}");
}

