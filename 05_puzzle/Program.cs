const int size = 4;
int zeroX = 2;
int zeroY = 2;

int[,] puzzle = new int[size, size]
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 0, 12 },
    { 13, 14, 15, 11 }
};

Print();

while (true)
{

    var key = Console.ReadKey().Key;

    switch (key)
    {
        case ConsoleKey.RightArrow:
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX - 1]);
            --zeroX;
            break;
        case ConsoleKey.LeftArrow:
            Swap(ref puzzle[zeroY, zeroX], ref puzzle[zeroY, zeroX + 1]);
            ++zeroX;
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
            if (puzzle[row, col] == 0)
                Console.Write($"[  ] ");
            else
                Console.Write($"[{puzzle[row, col],2}] ");
        }
        Console.WriteLine();
    }
}