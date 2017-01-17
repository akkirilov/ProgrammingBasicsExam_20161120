using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___03
{
    class Program
    {
        static void Main(string[] args)
        {
            int addults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string transportType = Console.ReadLine();

            decimal discount = 1;
            if (addults+students>50)
            {
                discount = 0.5m;
            }

            if (transportType == "train")
            {
                decimal trainAddults = addults * 24.99m * 2m;
                decimal trainStudents = students * 14.99m * 2m;
                Console.WriteLine("{0:f2}", ((((trainAddults + trainStudents)* discount) + (nights * 82.99m ))) * 1.1m);
            }
            else if (transportType == "bus")
            {
                decimal busAddults = addults * 32.50m * 2m;
                decimal busStudents = students * 28.50m * 2m;
                Console.WriteLine("{0:f2}", (busAddults + busStudents + (nights * 82.99m)) * 1.1m);
            }
            else if (transportType == "boat")
            {
                decimal shipAddults = addults * 42.99m * 2m;
                decimal shipStudents = students * 39.99m * 2m;
                Console.WriteLine("{0:f2}", (shipAddults + shipStudents + (nights * 82.99m)) * 1.1m);
            }
            else if(transportType == "airplane")
            {
                decimal planeAddults = (addults * 70.00m) * 2m;
                decimal planeStudents = (students * 50.00m) * 2m;
                //decimal price = (planeAddults + planeStudents + (nights * 82.99m));
                //decimal comission = (price * 0.1m);
                //price += comission;
                Console.WriteLine("{0:f2}", (planeAddults + planeStudents + (nights * 82.99m)) * 1.1m); ;
            }
        }
    }
}