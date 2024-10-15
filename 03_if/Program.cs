// See https://aka.ms/new-console-template for more information

// > < >= <= == !=
// if switch
var rand = new Random();

int score = 0;
int count = 0;

while (true)
{
    Console.Write("Enter your rate (1-6): ");
    if (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out int rate)) 
        continue;

    Console.Clear();
    
    int number = rand.Next(1, 7); // генерація випадкового числа з 1 до 7 (не включно)
    Console.WriteLine($"The number is {number}");

    if (rate == number)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You won! Thanks for playing!");
        score += 10;
        count++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You loose!");
        score -= 5;
        count = 0;
    }

    if (count == 2)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Good combination!");
        score += 50;
    }

    if (count == 3)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Jackpot!");
        score += 100;
    }

    Console.ResetColor();

    Console.WriteLine($"Score: {score}");
}



//... end!