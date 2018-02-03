using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Bonus17
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarApp.PrintCarInfo(CarApp.CreateCarArray(CarApp.GetNumberOfCars()));
            List<Car> CarList = new List<Car>();
            CarApp.AddCars(CarList);

            while (true)
            {
                CarApp.PrintCarInfo(CarList);
                int temp = CarApp.FindCar(CarList);
                if ( temp == 0)
                    break;
                else
                    Validate.ConfirmPurchase(CarList, temp);
            }
            Console.WriteLine("Have a good day!");
        }
        
    }
}
