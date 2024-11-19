
// створити метод: return_type name(parameter) { code }
// void - пусто

void PrintMessage(int count, string separator)
{
    for (int i = 0; i < count; ++i)
    {
        Console.Write("Hello" + separator);
    }
    Console.WriteLine();
}

PrintMessage(5, ".");
PrintMessage(3, "-");

// ... code

PrintMessage(10, ", ");

void ConvertUAHtoUSD(double uah)
{
    const double USD = 41.9;
    Console.WriteLine($"USD: {uah / USD:0.##}$");
}

ConvertUAHtoUSD(1200);
ConvertUAHtoUSD(50000);
ConvertUAHtoUSD(20);