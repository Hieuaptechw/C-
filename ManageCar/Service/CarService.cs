using ManageCar.Interface;
using ManageCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCar.Service
{
    class CarService : CarInterface

    {
        private  List<Car> ListCar;
        public CarService(List<Car> listCar)
        {
            ListCar = listCar;
        }

        public void InputCar(Car NewCar)
        {
            ListCar.Add(NewCar);
        }

        public void DisplayCar()
        {
            foreach (var item in ListCar)
            {
                item.ToString();
            }
        }
        public  int lengList()
        {
            return ListCar.Count();
        }

        public void SearchCar(string car)
        {
            List<Car> listCarSearch = ListCar.Where(c => c.Name.ToLower().Contains(car.ToLower())).ToList();

            foreach (var item in listCarSearch)
            {
                item.ToString();
            }
        }

        public void DeleteCar(int index)
        {
            ListCar.RemoveAt(index);
        }

        public void SortCar()
        {
            ListCar.Sort((x, y) => x.Price.CompareTo(y.Price));
        }

        public void EditCar()
        {
            
        }


    }
}
