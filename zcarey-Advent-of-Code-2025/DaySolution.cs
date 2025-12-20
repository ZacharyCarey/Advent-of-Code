public interface IDaySolution
{
    public static abstract byte Day { get; }
    public static abstract List<string> InputFiles { get; }
    public static abstract List<Type> Parts { get; }
}

public interface IPartSolution
{
    public object? Solve(string input);
}