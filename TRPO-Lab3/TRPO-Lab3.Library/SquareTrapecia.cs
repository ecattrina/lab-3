﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Library
{
    public static class SquareTrapecia
    {
        public static double Calculate( double base1, double base2, double height )
        {
            double area = 0.5 * (base1 + base2) * height;
            return area;
        }

    }
}
