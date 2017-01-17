using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___02
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodKG = int.Parse(Console.ReadLine());
            double foodsPerDayForDog = double.Parse(Console.ReadLine()) * days;
            double foodsPerDayForCat = double.Parse(Console.ReadLine()) * days;
            double foodsPerDayForTurtle = (double.Parse(Console.ReadLine()) / 1000d) * days;

            double neededFood = foodsPerDayForDog + foodsPerDayForCat + foodsPerDayForTurtle;

            if (neededFood <= foodKG) 
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodKG - neededFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(neededFood - foodKG));
            }
        }
    }
}