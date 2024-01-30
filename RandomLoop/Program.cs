namespace RandomLoop;

public static class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int current = random.Next(1, 11); // 난수가 7이 나오지않으면 아래 do 문을 실행해서 난수를 재생성하고 재생성한 난수가 8이상의 숫자라면 콘솔로 해당 난수를 찍는다. , 7이 나오면 이 loop 는 종료

        do
        {
            current = random.Next(1, 11);
            if (current >= 8)
                continue;
            Console.WriteLine(current);
        } while (current != 7);
    }
}
