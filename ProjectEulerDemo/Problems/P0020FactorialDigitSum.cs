namespace ProjectEulerDemo.Problems
{
    using System.Linq;
    using System.Numerics;

    public class P0020FactorialDigitSum : IEulerProblem
    {
        public string Name { get { return "P0020 Factorial digit sum"; } }

        public string Description { get { return "Find the sum of the digits in the number 100!"; } }

        public string Calculate()
        {
            return CalculateSumOfDigitsForFactorialOf(100).ToString();
        }

        public int CalculateSumOfDigitsForFactorialOf(int n)
        {
            return CalculateDigitSum(Factorial(n));
        }

        private static BigInteger Factorial(int factorialOf)
        {
            BigInteger ret = 1;
            for (var n = 2; n < factorialOf + 1; n++)
            {
                ret = ret * n;
            }
            return ret;
        }

        private static int CalculateDigitSum(BigInteger n)
        {
            return n.ToString().Sum(c => c - '0');
        }
    }
}