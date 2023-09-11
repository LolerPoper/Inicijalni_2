using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;

            Console.WriteLine("Unesite red znakova: ");
            a = Console.ReadLine();

            Console.WriteLine(a.Replace(" ", "_"));

            Console.ReadKey();
        }
    }
}
