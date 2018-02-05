using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus17
{
    class CarApp
    {
        public static void AddCars(List<Car> CarList)
        {
            CarList.Add(new Car("Chevy", "'Vette", 2018, 80000.00));
            CarList.Add(new Car("Ford", "Mustang", 2018, 75000.00));
            CarList.Add(new Car("Dodge", "Hellcat", 2018, 90000.00));
            CarList.Add(new UsedCar("Buick", "Encore", 2000, 4000.00, 30000));
            CarList.Add(new UsedCar("Ford", "Escort", 2003, 5000.00, 50000));
            CarList.Add(new UsedCar("GMC", "Yukon", 2002, 15000.00, 20000));
        }
        
        public static void PrintCarInfo(List<Car> x)
        {
            Console.WriteLine(new string('~', 40));
            Console.WriteLine("Make\t\tModel\t\tYear\t\tPrice");
            Console.WriteLine(new string('=', 40));

            int z = 1;
            foreach (Car i in x)
            {
                if (i.GetType() == typeof(UsedCar))
                {
                    Console.WriteLine("{0}:{1}\t\t{2}\t\t{3}\t\t${4:0.00} (Used) {5:0.0}mi", z, i.Make, i.Model, i.Year, i.Price, ((UsedCar)i).Mileage);
                    z++;
                }
                else
                {
                    Console.WriteLine("{0}:{1}\t\t{2}\t\t{3}\t\t${4:0.00}", z, i.Make, i.Model, i.Year, i.Price);
                    z++;
                }
            }
            Console.WriteLine($"{z}: Quit");
            Console.WriteLine(new string('~', 40));
        }

        public static int FindCar(List<Car> CarList)
        {
            Console.WriteLine("Which car would you like?");
            int x = Validate.CheckCarNumber(Console.ReadLine(), CarList);
            int y = x - 1;
            if (x > CarList.Count)
                return 0;
            if (CarList[y].GetType() == typeof(Car))
            {
                Console.WriteLine("{0}\t{1}\t{2}\t${3:0.0}", CarList[y].Make, CarList[y].Model, CarList[y].Year, CarList[y].Price);
                return x;
            }
            else if (CarList[y].GetType() == typeof(UsedCar))
            {
                Console.WriteLine("{0}\t{1}\t{2}\t${3:0.00} (Used) {4:0.0}mi", CarList[y].Make, CarList[y].Model, CarList[y].Year, CarList[y].Price, ((UsedCar)CarList[y]).Mileage);
                return x;
            }
            else
                return 0;
        }

        //public static int GetNumberOfCars()
        //{
        //    Console.WriteLine("How many American cars are there?");
        //    string TestInt = Console.ReadLine();
        //    while (true)
        //    {
        //        int Input;
        //        if (int.TryParse(TestInt, out Input) == false)
        //        {
        //            Console.WriteLine("Invalid input! Try again!");
        //            TestInt = Console.ReadLine();
        //        }
        //        else
        //            return Input;
        //    }
        //}

        //public static Car[] CreateCarArray(int Input)
        //{
        //    Car[] Cars = new Car[Input];

        //    for (int i = 0; i < Input; i++)
        //    {
        //        Cars[i] = GetCarInfo(i);
        //    }
        //    return Cars;
        //}

        //public static Car GetCarInfo(int x)
        //{
        //    Car Temp = new Car();
        //    Console.WriteLine($"Enter Car #{x+1} Make: ");
        //    Temp.Make = ValidMake(Console.ReadLine());

        //    Console.WriteLine($"Enter Car #{x+1} Model: ");
        //    Temp.Model = Console.ReadLine();

        //    Console.WriteLine($"Enter Car #{x+1} Year: ");
        //    Temp.Year = ValidYear(Console.ReadLine());

        //    Console.WriteLine($"Enter Car #{x+1} Price: ");
        //    Temp.Price = ValidPrice(Console.ReadLine());

        //    return Temp;
        //}
    }
}
