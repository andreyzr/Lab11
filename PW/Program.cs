using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            double c=Convert.ToDouble(Console.ReadLine());

            Quadratic quadratic = new Quadratic(a,b,c);
            Console.WriteLine(quadratic.Root());
            Console.ReadKey();
        }
    }
}
