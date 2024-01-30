using System;

namespace CalculatorTestApp1
{
    public static class MyProgram
    {
        public static void Main()
        {
            Console.WriteLine("Start.");
            RandomDice.Roll();
            Calculator.Compute();
        }
    }
}
