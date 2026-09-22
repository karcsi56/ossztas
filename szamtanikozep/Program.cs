using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamtanikozep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg az első számot ");
            int szam1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az második számot ");
            int szam2 = int.Parse(Console.ReadLine());
            double szamtanikozep = ((double)szam1+szam2)/2;

            Console.WriteLine($"A számok számtani közepe: {szamtanikozep}");
            Console.ReadLine();
        }
    }
}
