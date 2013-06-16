namespace ProjectEulerDemo.Problems
{
    public class P0002EvenFibonacciNumbers : IEulerProblem
    {
        public string Name { get { return "P0002 Even Fibonacci numbers"; } }

        public string Description { get { return "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms."; } }

        public string Calculate()
        {
            return SumOfEven(1000000).ToString();
        }

        public long SumOfEven(int upperLimit)
        {
            long sum = 0, current = 2, prev = 1;

            while (current < upperLimit)
            {
                if (current % 2 == 0)
                {
                    sum += current;
                }

                var tmp = current;
                current = current + prev;
                prev = tmp;
            }

            return sum;
        }
    }
}