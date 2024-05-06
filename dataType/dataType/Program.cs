using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valid=false;
            string valueType;
            Console.WriteLine("Enter the value: ");
            string inputValue=Console.ReadLine();
            Console.WriteLine("Press 1 for String: ");
            Console.WriteLine("Press 2 for Integer: ");
            Console.WriteLine("Press 3 for Boolean: ");
            Console.WriteLine("Enter: ");
            int inputType=Convert.ToInt32(Console.ReadLine());
            switch (inputType)
            {
                case 1:
                    valid = IsString(inputValue);
                    valueType = "String";
                    break;
                case 2:
                    valid = IsInt(inputValue);
                    valueType = "Number";
                    break;
                case 3:
                    valid=IsBool(inputValue);
                    valueType = "Boolean";
                    break;
                default:
                    valueType = "Unknown";
                    Console.WriteLine("No Typing Detected");
                    break;
            }
            Console.WriteLine("Your Enter the value : " + inputValue);
            if (valid)
            {
                Console.WriteLine("Correct,  you are input: " + valueType);
            }
            else
            {
                Console.WriteLine("Incorrect,  you are input: " + valueType);

            }
            Console.Read();
        }
        static bool IsString(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
        static bool IsInt(string value)
        {
            int retValue;
            return int.TryParse(value, out retValue);
        }
        static bool IsBool(string value)
        {
            bool boolValue;
            return bool.TryParse(value, out boolValue);

        }
    }
}
