using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int outStars = 1;
            int inLine = n * 2 - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', outStars));
                Console.Write(new string('\\', 1));
                Console.Write(new string('-', inLine));
                Console.Write(new string('/', 1));
                Console.Write(new string('*', outStars));
                Console.WriteLine();
                outStars++;
                inLine -= 2;
            }

            int newN = n / 3;
            outStars = n / 2;
            int inStars = n;
            for (int i = 0; i < newN; i++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', outStars));
                Console.Write(new string('\\', 1));
                Console.Write(new string('*', inStars));
                Console.Write(new string('/', 1));
                Console.Write(new string('*', outStars));
                Console.Write(new string('|', 1));
                Console.WriteLine();
                outStars++;
                inStars -= 2;
            }

            outStars = 1;
            inLine = n * 2 - 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', outStars));
                Console.Write(new string('\\', 1));
                Console.Write(new string('*', inLine));
                Console.Write(new string('/', 1));
                Console.Write(new string('-', outStars));
                Console.WriteLine();
                outStars++;
                inLine -= 2;
            }
        }
    }
}