namespace CalculatorTestApp1
{
    public static class Calculator
    {
        public static void Compute()
        {
            const int firstNumber = 1520000;
            const int secondNumber = 70000000;

            Console.WriteLine($" price : {firstNumber + secondNumber}");

            const int weight = 8;
            Console.WriteLine("Weight : " + (weight + 12) + ".");

            // 나누기 시 정확한 값을 원하면 decimal 을 명시
            const decimal decimalQuotient = 7.0m / 5;

            Console.WriteLine(decimalQuotient);

            // 괄호를 이용해 일시적인 타입 캐스팅 가능
            const decimal quotient = (decimal)firstNumber / (decimal)secondNumber;

            Console.WriteLine(quotient);
            Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

            // 연산자 우선순위 PEMDAS 는 수학 연산순서와 동일 , E(지수) 만 System.Math.Pow 메서드를 사용해야함
            const int value1 = 3 + 4 * 5;
            const int value2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(value2);

            // 전위 , 후위 연산자 동일
            int value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine($"Second: {value++}");
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));
        }
    }
}
