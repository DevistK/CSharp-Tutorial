namespace DungeonMonsters;

public static class Program
{
    private static void Main(string[] args)
    {
        Random dice = new Random();
        int hero = 10;
        int monster = 10;

        // 턴제 게임 공격논리 do while loop
        do
        {
            int attack = dice.Next(1, 11);
            monster -= attack;
            Console.WriteLine(
                $"Monster was damaged and lost {attack} health and now has {monster} health."
            );

            if (monster > 0)
            {
                attack = dice.Next(1, 11);
                hero -= attack;
                Console.WriteLine(
                    $"Hero was damaged and lost {attack} health and now has {hero} health."
                );
            }
        } while (hero > 0 && monster > 0);

        Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
    }
}
