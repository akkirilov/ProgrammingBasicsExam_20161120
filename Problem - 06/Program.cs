using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___06
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            int count = 1;

            for (int i = 1; i <= player1; i++)
            {
                for (int j = 1; j <= player2; j++)
                {
                    if (count <= battles)
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                        count++;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}