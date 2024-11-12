internal class Program
{
    static string direction = "Up";
    
    static int tankX = 0;
    static int tankY = 0;
    
    public static void Main(string[] args)
    {
        Console.CursorVisible = false;
        DrawTankUp();
            
        while (true)
        {
            Move();
        }
    }

    static void Move()
    {
        var key = Console.ReadKey().Key;

        switch (key)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.W:
                ClearTank();
                
                if (direction == "Up")
                    tankY--;
                else
                    direction = "Up";
                
                DrawTankUp();
                break;
            case ConsoleKey.DownArrow:
            case ConsoleKey.S:
                ClearTank();
                
                if (direction == "Down")
                    tankY++;
                else
                    direction = "Down";
                
                DrawTankDown();
                break;
            case ConsoleKey.LeftArrow:
            case ConsoleKey.A:
                ClearTank();
                
                if (direction == "Left")
                    tankX -= 2;
                else
                    direction = "Left";
                
                DrawLeft();
                break;
            case ConsoleKey.RightArrow:
            case ConsoleKey.D:
                ClearTank();
                
                if (direction == "Right")
                    tankX += 2;
                else
                    direction = "Right";
                
                DrawRight();
                break;
        }
    }
    
    static void ClearTank()
    {
        Console.SetCursorPosition(tankX, tankY);
        Console.Write("      ");
        Console.SetCursorPosition(tankX, tankY + 1);
        Console.Write("      ");
        Console.SetCursorPosition(tankX, tankY + 2);
        Console.Write("      ");
    }
    static void DrawTankUp()
    {
        Console.SetCursorPosition(tankX, tankY);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("  ██  ");
        Console.SetCursorPosition(tankX, tankY + 1);
        Console.Write("██████");
        Console.SetCursorPosition(tankX, tankY + 2);
        Console.Write("██  ██");
        Console.ResetColor();
    }
    static void DrawTankDown()
    {
        Console.SetCursorPosition(tankX, tankY);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("██  ██");
        Console.SetCursorPosition(tankX, tankY + 1);
        Console.Write("██████");
        Console.SetCursorPosition(tankX, tankY + 2);
        Console.Write("  ██  ");
        Console.ResetColor();
    }
    static void DrawLeft()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.SetCursorPosition(tankX, tankY);
        Console.Write("  ████");
        Console.SetCursorPosition(tankX, tankY + 1);
        Console.Write("████  ");
        Console.SetCursorPosition(tankX, tankY + 2);
        Console.Write("  ████");
        Console.ResetColor();
    }
    static void DrawRight()
    {
        Console.SetCursorPosition(tankX, tankY);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("████  ");
        Console.SetCursorPosition(tankX, tankY + 1);
        Console.Write("  ████");
        Console.SetCursorPosition(tankX, tankY + 2);
        Console.Write("████  ");
        Console.ResetColor();
    }
}