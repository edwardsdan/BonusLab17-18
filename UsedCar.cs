using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class UsedCar : Car
    {
        private double mileage;
        public double Mileage
        {
            set { mileage = value; }
            get { return mileage; }
        }
        public UsedCar(string Make, string Model, int Year, double Price, double Miles):base(Make,Model,Year,Price)
        {
            Miles = Mileage;
        }
    }
}
