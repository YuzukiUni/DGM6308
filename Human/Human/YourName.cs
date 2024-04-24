using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
   public class YourName
    {
        public string firstName = "";
        public string lasttName = "";
        public string height = "";
        public int weight = 0;
        public int age = 0;


        public YourName() {
            Console.WriteLine("Your Name was Called");
        }
        public YourName(string firstName, string lasttName, string height, int weight, int age)
        {
            this.firstName = firstName;
            this.lasttName = lasttName;
            this.height = height;
            this.weight = weight;
            this.age = age;
        }
        public void introduction()
        {
            if (age > 18) {
                Console.WriteLine("Hello, my name is {0} {1}, I am {2}, and weigh{3}, Also I am {4} years old", firstName,lasttName,weight,height,age);
            }
            else
            {
                Console.WriteLine("Sorry I can't introduce myself, I am underage");
            }
        }
    }
}
