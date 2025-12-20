
public class Day01 : IDaySolution
{
    public static byte Day => 1;
    public static List<string> InputFiles => new()
    {
        "Input", "Example"
    };

    public static List<Type> Parts => new()
    {
        typeof(Day01_Part1)
    };
}

public class Day01_Part1 : IPartSolution
{
    public object? Solve(string input)
    {
        return "Success";
    }
}