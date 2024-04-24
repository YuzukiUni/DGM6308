using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            YourName Uni = new YourName("Yao","Huang", "182",67,26);
            YourName YuNi = new YourName("Uni", "Huang", "182", 67, 26);
            Uni.introduction();
            YuNi.introduction();
            YourName Kanon = new YourName();
            Kanon.introduction();
        }
    }
}
