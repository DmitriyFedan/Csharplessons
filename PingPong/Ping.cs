
public class Ping
{
    public delegate void pingDelegate();
    public event pingDelegate PingEvent;
    private Random _random = new Random();
    public void Play()
    {
        int magicnumber = _random.Next(1, 10);
        if (magicnumber != 5)
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Ping получил Pong");
            PingEvent?.Invoke();
        }
        else Console.WriteLine("Pong победил");
        
    }
}
