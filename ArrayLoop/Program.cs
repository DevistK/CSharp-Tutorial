namespace ArrayLoop;

public static class Program
{
    private static void Main(string[] args)
    {
        string[] fraudulentOrderIds = { "A123", "B456", "D789" };

        foreach (string code in fraudulentOrderIds)
        {
            Console.WriteLine(code);
        }

        int[] inventory = { 200, 450, 700, 175, 250 };

        int sum = 0;
        int bin = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }

        Console.WriteLine($"We have {sum} items in inventory.");
    }
}
