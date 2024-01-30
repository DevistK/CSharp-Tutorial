namespace FizzBuzz;

public static class Program
{
    private static void Main(string[] args)
    {
        // FizzBuzz
        for (int i = 1; i <= 100; i++)
        {
            string fizzBuzz = "";

            if (i % 3 == 0)
            {
                fizzBuzz = "Fizz";
                if (i % 5 == 0)
                {
                    fizzBuzz = "FizzBuzz";
                }
            }
            else if (i % 5 == 0)
            {
                fizzBuzz = "Buzz";
            }

            Console.WriteLine(fizzBuzz != "" ? $"{i} - {fizzBuzz}" : $"{i}");
        }
    }
}
