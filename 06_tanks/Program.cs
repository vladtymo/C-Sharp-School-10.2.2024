internal class Program
{
    public static void Main(string[] args)
    {
        DrawTankUp();
        Console.WriteLine();
        DrawTankDown();
    }
    
    static void DrawTankUp()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  █  ");
        Console.WriteLine("█████");
        Console.WriteLine("██ ██");
        Console.ResetColor();
    }
    static void DrawTankDown()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("██ ██");
        Console.WriteLine("█████");
        Console.WriteLine("  █  ");
        Console.ResetColor();
    }
}