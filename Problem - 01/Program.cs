using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem___01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal scumriyaPrice = decimal.Parse(Console.ReadLine());
            decimal tzatzaPrice = decimal.Parse(Console.ReadLine());
            decimal palamudKG = decimal.Parse(Console.ReadLine()) * (scumriyaPrice * 1.6m);
            decimal safridKG = decimal.Parse(Console.ReadLine()) * (tzatzaPrice * 1.8m);
            decimal midiKG = decimal.Parse(Console.ReadLine()) * 7.5m;

            Console.WriteLine("{0:f2}",(palamudKG+safridKG+midiKG));
        }
    }
}