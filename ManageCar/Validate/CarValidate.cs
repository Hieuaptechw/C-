using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCar.Validate
{   class CarValidate
    {
        public static string InputString(string InputString)
        {

            string str;
            do {
                 str = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(str))
                {
                    Console.Write(InputString + "is not valid!");
                }
            } 
            while (string.IsNullOrWhiteSpace(str));
            return str;

        }
        public static double InputDouble(string InputDouble)
        {
            double value;
            do
            {

                if (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
                {
                    Console.WriteLine(InputDouble + " Invalid value! Please enter a number greater than 0.");
                }
            } while (value <= 0);

            return value;
        }

        public static int InputInt(string IntInput)
        {
            int value;
            do
            {

                if (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
                {
                    Console.WriteLine(IntInput + " Invalid value! Please enter a number greater than 0.");
                }
            } while (value <= 0);

            return value;
        }
  
    }
}
