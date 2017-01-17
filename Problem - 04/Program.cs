using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double car = 0;
            double van = 0;
            double smallBus = 0;
            double bigBus = 0;
            double train = 0;

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int currentGroup = int.Parse(Console.ReadLine());

                if (currentGroup <= 5)
                {
                    car += currentGroup;
                    count += currentGroup;
                }
                else if (currentGroup >= 6 && currentGroup <=12)
                {
                    van += currentGroup;
                    count += currentGroup;
                }
                else if (currentGroup >= 13 && currentGroup <= 25)
                {
                    smallBus += currentGroup;
                    count += currentGroup;
                }
                else if (currentGroup >= 26 && currentGroup <= 40)
                {
                    bigBus += currentGroup;
                    count += currentGroup;
                }
                else if (currentGroup >= 41)
                {
                    train += currentGroup;
                    count += currentGroup;
                }
            }

            Console.WriteLine("{0:f2}%", (car/count)*100);
            Console.WriteLine("{0:f2}%", (van / count) * 100);
            Console.WriteLine("{0:f2}%", (smallBus / count) * 100);
            Console.WriteLine("{0:f2}%", (bigBus / count) * 100);
            Console.WriteLine("{0:f2}%", (train / count) * 100);
        }
    }
}