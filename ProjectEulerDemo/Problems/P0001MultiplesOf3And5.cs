using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerDemo.Problems
{
    public class P0001MultiplesOf3And5 : IEulerProblem
    {
        public string Name { get { return "P0001 Multiples of 3 and 5"; } }

        public string Description { get { return "Find the sum of all the multiples of 3 or 5 below 1000."; } }

        public string Calculate()
        {
            return CalculateMultiples(new[] { 3, 5 }, 1000).ToString();
        }

        public int CalculateMultiples(IEnumerable<int> multiplesOf, int max)
        {
            return multiplesOf
                .SelectMany(multiple => GenerateSequenceOfMultiples(multiple, max))
                .Distinct()
                .Sum();
        }

        private static IEnumerable<int> GenerateSequenceOfMultiples(int multiplier, int max)
        {
            for (var n = 0; n < max; n += multiplier)
            {
                yield return n;
            }
        }
    }
}
