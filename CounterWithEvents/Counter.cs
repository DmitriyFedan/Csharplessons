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
        public int Num { get; init; } //  будем записывать сюда искомое число при сосздании
        public Counter(int numberForEvent)
        { 
            Num = numberForEvent;
        }
        public void Count()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i == Num)
                {
                    MyEvent?.Invoke();
                }
            }
        }    
    }

}
