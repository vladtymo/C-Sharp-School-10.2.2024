int ShowRandom(int max)
{
    int value = new Random().Next(max);
    Console.Write(value + "\t");
    
    return value;
}

ShowRandom(100);
ShowRandom(55);
ShowRandom(1000);
ShowRandom(14);

while (ShowRandom(100) != 52) { }

void ShowRectangle(int height, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine();
    for (int i = 1; i <= height; i++)
    {
        Console.Write(new string(' ', height - i));
        Console.WriteLine(new string('*', i * 2));
    }
    Console.ResetColor();
}

ShowRectangle(10, ConsoleColor.Green);
ShowRectangle(5, ConsoleColor.Blue);
ShowRectangle(3, ConsoleColor.Yellow);
