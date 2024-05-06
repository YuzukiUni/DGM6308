using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int value=num.Next(1,13);
            switch (value)
            {
                case 13:Console.WriteLine("You draw the King");
                    break;
                case 12: Console.WriteLine("You draw the Queen");
                    break;
                case 11: Console.WriteLine("You draw the Jack");
                    break;
                case 1: Console.WriteLine("You draw the Ace");
                    break;
                    default: Console.WriteLine("you draw the value"+value); 
                    break;  
            }
            Console.Read();
        }
    }
}
