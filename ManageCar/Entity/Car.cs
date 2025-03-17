using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCar.Entity
{
    class Car
    {
        private int Id { get; set; }
        public string? Name { get; set; }
        private string? Brand { get; set; }
        public double Price { get; set; }
        private int Quantity { get; set; }
        public Car()
        {

        }
        public Car(int id, string? name, string? brand, double price, int quantity)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Price = price;
            Quantity = quantity;
        }
        public void ToString()
        {
            Console.Write("ID" + Id + "Name " + Name);
        }
    }
}
