using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент k:");
            double k = Convert.ToDouble(Console.ReadLine());

            rootSearch rootsearch = new rootSearch(b, k);
            Console.WriteLine(rootsearch.Root());
            Console.ReadKey();
        }
    }
}
