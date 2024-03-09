using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Library
{
    public class SquareTrapecia
    {
        public double Calculate( double base1, double base2, double height )
        {
            double area = 1 / 2 * (base1 + base2) * height;
            return area;
        }
    }
}
