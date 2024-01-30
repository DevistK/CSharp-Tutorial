namespace CalculatorTestApp1
{
    public static class RandomDice
    {
        public static void Roll()
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine($"Dice Roll : {roll}");
            Console.WriteLine("Last Step Roll");
            StepRoll(dice);
        }

        private static void StepRoll(Random dice)
        {
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll : {roll1}");
            Console.WriteLine($"Second roll : {roll2}");
            Console.WriteLine($"Third roll : {roll3}");
        }
    }
}
