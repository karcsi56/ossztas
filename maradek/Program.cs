using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maradek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kérlek egy pénzösszeget:");
            int osszeg = int.Parse(Console.ReadLine());
            Console.WriteLine($" A kerekített összeg:{osszeg - osszeg % 5}");

            Console.ReadLine();
        }
    }
}
