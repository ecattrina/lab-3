using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TRPO_Lab3.Tests
{
    public class UnitTest1

    {   [Test]
        public void Test1()
        {
            const double base1 = 1;
            const double base2 = 2;
            const double height = 1;

            const double expected = 1.5; 

            var result = TRPO_Lab3.Library.SquareTrapecia.Calculate(base1, base2, height);

            Assert.AreEqual(expected, result);
        }

        public void Test2()
        {
            const double base1 = 1;
            const double base2 = 2;
            const double height = -1;

            Assert.Throws<Exception>(() => TRPO_Lab3.Library.SquareTrapecia.Calculate(base1, base2, height));
        }
    }
}
