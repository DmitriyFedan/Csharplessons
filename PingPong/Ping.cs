
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
