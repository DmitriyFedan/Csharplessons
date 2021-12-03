
try 
{
    Ping ping = new Ping();
    Pong pong = new Pong();

    ping.PingEvent += pong.Play;
    pong.PongEvent += ping.Play;


    ping.Play();
    Console.WriteLine("Конец программы");
}
catch (Exception ex)
{ Console.WriteLine($"Что то вышло из под контроля ошибка: {ex.Message}"); }
