namespace ProjectEulerDemo.Tests
{
    using NUnit.Framework;

    using ProjectEulerDemo.Problems;

    [TestFixture]
    public class P0020FactorialDigitSumTest
    {
        [Test]
        public void Sum_of_digits_for_factorial_of_10()
        {
            // 10! = 10  9  ...  3  2  1 = 36288009
            Assert.AreEqual(3 + 6 + 2 + 8 + 8 + 0 + 0, new P0020FactorialDigitSum().CalculateSumOfDigitsForFactorialOf(10));
        }
    }
}