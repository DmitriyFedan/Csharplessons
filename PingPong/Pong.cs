
public class Pong
{
    //Action<> Mydelegate;
    public delegate void pongDelegate();
    public event pongDelegate PongEvent;
    private Random _random = new Random();

    public void Play()
    {
        int magicnumber = _random.Next(1, 10); 
        if (magicnumber != 5)
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Pong получил Ping");
            PongEvent?.Invoke();
        }
        else Console.WriteLine("Ping победил");

        
    }
}