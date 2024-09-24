using System.Text;

Console.WriteLine("Hello, World!");

// коментар

// cw + TAB = Console.WriteLine();
Console.WriteLine("Do like C#?");

Console.WriteLine("Thinking....");

// escape sequences: \n \t \' \"

// Write() - не ставить новий рядок після тексту
// WriteLine() - переносить на новий рядок після тексту
Console.Write("Hello...\nBye!");
Console.Write("Hello...\tTab\t\tTab");
Console.Write("Hello...");

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("\n\nGlory to Ukraine!");

// скидаємо кольори
Console.ResetColor();

// кодування для укр символів
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Гарного дня!");

// --------------- введення з консолі

// типи даних:
// string   - рядок
// int      - ціле число

// створення змінної: тип ім'я = значення;
string nickname = Console.ReadLine();
string username = "vladnaz";

Console.WriteLine($"Hello, {nickname} {2 + 2}!");

int birthYear = int.Parse(Console.ReadLine());

Console.WriteLine($"You are {DateTime.Now.Year - birthYear} years old!");