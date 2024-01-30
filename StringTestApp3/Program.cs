const string firstName = "Bob";
const string greeting = "Hello";

const string programName = "First-Project";

Console.WriteLine($"{greeting} {firstName}! ");

Console.WriteLine($@"C:\Program\{programName}\Data");

const string projectName = "ACME";

const string englishMessage = "View English output";
const string englishLocation = $@"c:\Exercise\{projectName}\data.txt";

const string russianMessage =
    "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
const string russianLocation = $@"c:\\Exercise\\{projectName}\\ru-RU\\data.txt\";

Console.WriteLine($"{englishMessage}:\n${englishLocation}\t\t");
Console.Write($"{russianMessage}:\n${russianLocation}\t\t");
