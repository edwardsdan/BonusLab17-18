using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Bonus17
{
    class Validate
    {

        public static void ConfirmPurchase(List<Car> CarList, int x)
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to buy this car? (y/n)");
            string Input = Console.ReadLine().ToLower();

            while (true)
            {
                if (Regex.IsMatch(Input, "^(yes|y)$"))
                {
                    CarList.Remove(CarList[x-1]);
                    Console.WriteLine("Most bodacious! Our finance department will be in touch shortly!");
                    break;
                }
                else if (Regex.IsMatch(Input, "^(no|n)$"))
                    break;
                else
                {
                    Console.WriteLine("Invalid input. Try again!");
                    Input = Console.ReadLine().ToLower();
                }
            }
            
        }
        public static int CheckCarNumber(string Input, List<Car> CarList)
        {
            int ToReturn;
            while (true)
            {
                bool ThisBool = int.TryParse(Input, out ToReturn);
                if (ThisBool == true && ToReturn > 0 && ToReturn <= CarList.Count)
                    return ToReturn;
                else if (ToReturn == CarList.Count+1)
                    return 7;
                else
                {
                    Console.WriteLine("That's not an option");
                    Input = Console.ReadLine();
                }
            }
        }
        //public static int ValidYear(string Input)
        //{
        //    int ToReturn;
        //    while (true)
        //    {
        //        if (int.TryParse(Input, out ToReturn) == true && int.Parse(Input) <= 2018 && int.Parse(Input) >= 1903)
        //        {
        //            return ToReturn;
        //        }
        //        else
        //        {
        //            Console.WriteLine("That's not a valid year! Try again!");
        //            Input = Console.ReadLine();
        //        }

        //    }
        //}
        //public static double ValidPrice(string Input)
        //{
        //    double ToReturn;
        //    while (true)
        //    {
        //        if (double.TryParse(Input, out ToReturn) == false)
        //        {
        //            Console.WriteLine("That's not a valid price! Try again!");
        //            Input = Console.ReadLine();
        //        }
        //        else
        //            break;
        //    }
        //    return ToReturn;
        //}
        //public static string ValidMake(string Input)
        //{
        //    while (true)
        //    {
        //        if (!Regex.IsMatch(Input, "^(ford|gmc|chrysler|dodge|jeep|buick)$"))
        //        {
        //            Console.WriteLine("That's not an American car! Try again!");
        //            Input = Console.ReadLine().ToLower();
        //        }
        //        else
        //            return Input;
        //    }
        //}
        //public static string ValidModel(string Input)
        //{
        //    while (true)
        //    {
        //        if (!Regex.IsMatch(Input, @"^([A-Z][^0-9]\S+)$"))
        //        {
        //            Console.WriteLine("You can make up your own model, but be careful...");
        //            Input = Console.ReadLine();
        //        }
        //        else
        //            return Input;
        //    }
        //}
    }
}
