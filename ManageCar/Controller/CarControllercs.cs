using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageCar.Entity;
using ManageCar.Service;
using ManageCar.Validate;
namespace ManageCar.Controller
{
    class CarControllercs
    {
        private CarService csv;
        public CarControllercs(CarService carService)
        {
            csv = carService;
        }
        public void InputCar()
        {
            int Id = csv.lengList();
            Console.WriteLine(Id);
            Console.Write("Enter Name Car:");
            string Name = CarValidate.InputString("Name Car ");
            Console.Write("Enter Brand Car:");
            string Brand = CarValidate.InputString("Brand Car ");
            Console.Write("Enter Price Car:");
            double Price = CarValidate.InputDouble("Price car");
            Console.Write("Enter Quanity Car:");
            int Quantity = CarValidate.InputInt("Quantity car");
            Car newCar = new Car(Id,Name, Brand,Price, Quantity);
            csv.InputCar(newCar);
        }
        public void DisplayCar()
        {

            csv.DisplayCar();
        }
        public void SearchCar()
        {
            Console.Write("Enter Name Car:");
            string Name = CarValidate.InputString("Name Car ");
            csv.SearchCar(Name);
        }
        public void DeleteCar()
        {
            Console.Write("Enter Index Delete Car:");
            int index = CarValidate.InputInt("Index car");
            csv.DeleteCar(index);
        }
        public void SortCar()
        {
           
            csv.SortCar();
        }
    }
}
