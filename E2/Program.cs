using System.ComponentModel.DataAnnotations;

namespace EX1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Nhập sản phẩm");
                Console.WriteLine("2. Hiển thị danh sách sản phẩm");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn một tùy chọn: ");
                int choice = Validator.InputInt();

                switch (choice)
                {
                    case 1:
                        Product.AddProduct();
                        break;
                    case 2:
                        Product.DisplayProducts();
                        break;
                    case 3:
                        Console.WriteLine("Thoát chương trình...");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại!");
                        break;
                }
            }
        }
    }

}
