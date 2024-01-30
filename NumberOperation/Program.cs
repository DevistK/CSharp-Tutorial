namespace NumberOperation;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Start");

        int firstValue = 500;
        int secnodValue = 600;
        int largerValue;

        largerValue = Math.Max(firstValue, secnodValue);

        Console.WriteLine(largerValue);
    }
}
