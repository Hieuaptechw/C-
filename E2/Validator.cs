using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EX1
{
    class Validator
    {
        public static int InputInt()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Giá trị không hợp lệ, vui lòng nhập lại: ");
            }
            return value;
        }

        public static string InputString()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                    Console.Write("Không được để trống, vui lòng nhập lại: ");
            } while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        public static double InputDouble()
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Giá trị không hợp lệ, vui lòng nhập lại: ");
            }
            return value;
        }
    }
}
