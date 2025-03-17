using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageCar.Entity;
namespace ManageCar.Interface
{
    interface CarInterface
    {
        void InputCar(Car car);
        void DisplayCar();
        void SearchCar();
        void DeleteCar();
        void SortCar();
        void EditCar();
        
    }
}
