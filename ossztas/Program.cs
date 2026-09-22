using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ossztas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kérek egy számot");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"A számköbe:{Math.Pow(szam,(double)1/3)}");

           Console.ReadKey();
        }
    }
}
