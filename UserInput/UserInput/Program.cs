using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Our result is: " + Try());
            Console.Read();
        }
        public int Calculate()
        {
            int x;
            int y;
            Console.WriteLine("Enter the integer: ");
            string value1 = Console.ReadLine();

            try
            {
                x = int.Parse(value1);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed!, you must enter an integer");
                x = 0;
            }
            Console.WriteLine("Input another integer: ");
            string value2 = Console.ReadLine();
            try
            {
                y = int.Parse(value2);
            }
            catch (Exception)
            {
                Console.WriteLine("Failed!, you must enter an integer");
                y = 0;
            }
            Console.WriteLine("Input another integer: ");
            int result = x + y;
            return result;
        }
        public static int Try()
        {
            int c;
            int d;
            int total = 0;
            while (true)
            {
                Console.WriteLine("Enter the integer: ");
                string value3 = Console.ReadLine();
                if (int.TryParse(value3, out c))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid, please input the integer");
                }

            }
            while (true)
            {
                Console.WriteLine("Enter the integer: ");
                string value4 = Console.ReadLine();
                if (int.TryParse(value4, out d))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid, please input the integer");
                }

            }
            total = c * d;
            return total;
        }
    }

}
