

Ping ping = new Ping();
Pong pong = new Pong();

ping.PingEvent += pong.Play;
pong.PongEvent += ping.Play;


ping.Play();

public class Ping
{
    public delegate void pingDelegate();
    public event pingDelegate PingEvent;
    public void Play()
    {
        int magicnumber = new Random().Next(1, 10);
        if (magicnumber != 5)
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Ping получил Pong");
            PingEvent();
        }
        else Console.WriteLine("Pong победил");
        
    }
}

public class Pong
{
    //Action<> Mydelegate;
    public delegate void pongDelegate();
    public event pongDelegate PongEvent;

    public void Play()
    {
        int magicnumber = new Random().Next(1, 10);
        if (magicnumber != 5)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Pong получил Ping");
            PongEvent();
        }
        else Console.WriteLine("Ping победил");

        
    }
}