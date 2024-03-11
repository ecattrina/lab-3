using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Tests
{
    public class UnitTest1

    {
        public void Test1()
        {
            const double base1 = 1;
            const double base2 = 2;
            const double height = 1;

            var result = TRPO_Lab3.Library.SquareTrapecia.Calculate(base1, base2, height);


        }
    }
}
