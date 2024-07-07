internal class Program
{
    private static void Main(string[] args)
    {
        var grades = new List<double>
        {
            12.7,
            10.3,
            6.11,
            4.1,
            56.1
        };

        var result = 0.0;

        foreach (var grade in grades)
        {
            result += grade;
        }

        System.Console.WriteLine($"Average: {result / grades.Count:n2}");
    }
}