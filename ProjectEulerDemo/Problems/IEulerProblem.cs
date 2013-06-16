namespace ProjectEulerDemo.Problems
{
    public interface IEulerProblem
    {
        string Name { get; }

        string Description { get; }

        string Calculate();
    }
}