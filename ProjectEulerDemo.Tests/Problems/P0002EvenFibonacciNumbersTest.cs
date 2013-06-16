namespace ProjectEulerDemo.Tests
{
    using NUnit.Framework;

    using ProjectEulerDemo.Problems;

    [TestFixture]
    public class P0002EvenFibonacciNumbersTest
    {
        [Test]
        public void Sum_of_even_numbers_below_100()
        {
            // fibonaccis below 100: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            Assert.AreEqual(2 + 8 + 34, new P0002EvenFibonacciNumbers().SumOfEven(100));
        }
    }
}