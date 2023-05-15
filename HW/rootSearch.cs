using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class rootSearch
    {
        double b;
        double k;

        public rootSearch(double b, double k)
        {
            this.b = b;
            this.k = k;
        }

        public string Root()
        {
            if (k == 0&&b==0)
            {
                return "Решение любое x";
            }
            if (k == 0&&b!=0)
            {
                return "Решения нет";
            }
            return $"Корень уровнения равен:{-b / k}";
           
        }
    }
}
