using System;
using System.Collections.Generic;
using ManageCar.Controller;
using ManageCar.Entity;
using ManageCar.Service;

namespace ManageCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> listCar = new List<Car>();
            CarService csv = new CarService(listCar);
            CarControllercs ccl = new CarControllercs(csv);
       

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=========================================");
                Console.WriteLine("|         CAR MANAGEMENT SYSTEM         |");
                Console.WriteLine("=========================================");
                Console.WriteLine("| 1. Add new car                        |");
                Console.WriteLine("| 2. Display all cars                   |");
                Console.WriteLine("| 3. Search car by model                |");
                Console.WriteLine("| 4. Delete car                         |");
                Console.WriteLine("| 5. Sort By Price                      |");
                Console.WriteLine("| 6. Exit                               |");
                Console.WriteLine("=========================================");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ccl.InputCar();
                        break;
                    case "2":
                        ccl.DisplayCar();
                        break;
                    case "3":
                        ccl.SearchCar();
                        break;
                    case "4":
                        ccl.DeleteCar();
                        break;
                    case "5":
                        ccl.SortCar();
                        break;
                    case "6":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

                Console.Write("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
