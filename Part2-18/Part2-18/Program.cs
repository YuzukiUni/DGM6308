using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2_18
{
    internal class Program
    {
        public class DecreasingCounter
        {
            private int value;   // a variable that remembers the value of the counter

            public DecreasingCounter(int initialValue)
            {
                this.value = initialValue;
            }

            public void PrintValue()
            {
                Console.WriteLine("value: " + this.value);
            }

            public void decrement()
            {
                if (this.value > 0)
                {
                    this.value--;
                }
            }

        }

        public static void Main(string[] args)
        {
            DecreasingCounter counter = new DecreasingCounter(10);
            counter.PrintValue();

            counter.decrement();
            counter.PrintValue();

            counter.decrement();
            counter.PrintValue();
        }
    }
}
