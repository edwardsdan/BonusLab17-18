using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class Car
    {
        #region Fields
        private string make;
        private string model;
        private int year;
        private double price;
        #endregion

        #region Properties
        public string Make
        {
            set { make = value; }
            get { return make; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        #endregion

        #region Constructors
        public Car()
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;
        }
        public Car(string InputMake, string InputModel, int InputYear, double InputPrice)
        {
            Make = InputMake;
            Model = InputModel;
            Year = InputYear;
            Price = InputPrice;
        }
        #endregion
        
    }
}
