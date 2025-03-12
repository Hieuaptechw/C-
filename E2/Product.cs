using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{

    class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        private static List<Product> products = new List<Product>();

        public static void AddProduct()
        {
            Product product = new Product();
            Console.Write("Nhập ID sản phẩm: ");
            product.ID = Validator.InputInt();
            Console.Write("Nhập tên sản phẩm: ");
            product.ProductName = Validator.InputString();
            Console.Write("Nhập giá sản phẩm: ");
            product.Price = Validator.InputDouble();
            products.Add(product);
            Console.WriteLine("Sản phẩm đã được thêm!");
        }

        public static void DisplayProducts()
        {
            Console.WriteLine("\nDanh sách sản phẩm:");
            foreach (var p in products)
            {
                Console.WriteLine($"ID: {p.ID}, Tên: {p.ProductName}, Giá: {p.Price}");
            }
        }
    }
}
