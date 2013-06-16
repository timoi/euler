using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDemo.Tests
{
    using NUnit.Framework;

    using ProjectEulerDemo.Problems;

    [TestFixture]
    public class P0001MultiplesOf3And5Test
    {
        [Test]
        public void Sum_of_multiples_below_10()
        {
            Assert.AreEqual(3 + 5 + 6 + 9, new P0001MultiplesOf3And5().CalculateMultiples(new[] { 3, 5 }, 10));
        }
    }
}
