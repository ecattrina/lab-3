using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TRPO_Lab3.Tests
{
    public class UnitTest2
    {   [Test]
        public void Test1()
        {
            const double base1 = 2;
            const double base2 = 2;
            const double height = 1;

            const double expected = 2;

            var result = TRPO_Lab3.Library.SquareTrapecia.Calculate(base1, base2, height);

            Assert.AreEqual(expected, result);
        }
    }
}
