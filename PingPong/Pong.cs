
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