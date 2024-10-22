const int size = 4;
const int emptyNumber = 16;

int zeroX = 2;
int zeroY = 2;

int[,] puzzle = new int[size, size]
{
    { 7, 2, 6, 4 },
    { 8, 11, 9, 13 },
    { 3, 10, 16, 12 },
    { 1, 5, 15, 14 }
};

Print();

while (true)
{

    var key = Console.ReadKey().Key;

    switch (key)
    {
        case ConsoleKey.RightArrow:
            // якщо пуста комірка знаходиться в першій колонці
            if (zeroX == 0) 
                break; // вихід

            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX - 1]);
            --zeroX;
            break;
        case ConsoleKey.LeftArrow:
            if (zeroX == size - 1) break;

            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX + 1]);
            ++zeroX;
            break;
        case ConsoleKey.UpArrow:
            if (zeroY == size - 1) break;

            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY + 1, zeroX]);
            ++zeroY;
            break;
        case ConsoleKey.DownArrow:
            if (zeroY == 0) break;

            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY - 1, zeroX]);
            --zeroY;
            break;
        default:
            break;
    }

    Console.Clear();
    Print();
}

static void Swap(ref int first, ref int second)
{
    int temp = first;
    first = second;
    second = temp;
}

void Print()
{
    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            // перевірка чи комірка на свому місці
            if (puzzle[row, col] == row * size + col + 1)
                Console.ForegroundColor = ConsoleColor.Green;
            
            if (puzzle[row, col] == emptyNumber) // 16
                Console.Write($"[  ] ");
            else
                Console.Write($"[{puzzle[row, col],2}] ");

            Console.ResetColor();
        }
        Console.WriteLine();
    }
}