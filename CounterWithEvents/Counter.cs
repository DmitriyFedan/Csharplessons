using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterWithEvents
{
    public class Counter
    {

        public delegate void MyDelegate(); 
        public event MyDelegate MyEvent;
        public int num { get; init; } //  будем записывать сюда искомое число при сосздании
        public Counter(int numberForEvent)
        { 
            num = numberForEvent;
        }
        public void Count()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == num)
                {
                    MyEvent?.Invoke();
                }
            }
        }    
    }

    class Handler1
    {
        public void GetMessage()
        {
            Console.WriteLine("пора действовать ведь уже 77");
        }
    }

    class Handler2
    {
        public void GetMessage()
        {
            Console.WriteLine("уже 77 давно пора было начать");
        }
    }

}
