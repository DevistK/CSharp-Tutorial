// 온도를 화씨에서 섭씨로 변환하려면 먼저 32를 뺀 값에 5/9를 곱합니다.
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * 5m / 9m;
string message = $"The temperature is {celsius} Celsius.";

Console.WriteLine(message);
