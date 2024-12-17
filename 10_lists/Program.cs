// -------- list

List<double> prices = new() { 1200, 99.5, 2010, 450.35, 10, 2300, 55 };

Console.WriteLine("Count: " + prices.Count);
Console.WriteLine("Sum: " + prices.Sum());
Console.WriteLine("Avg: " + prices.Average());
Console.WriteLine("Min: " + prices.Min());
Console.WriteLine("Max: " + prices.Max());

prices.Add(789);
prices.Remove(99.5);
prices.RemoveAt(0);

// ! - not
if (!prices.Contains(50.5))
{
    prices.Add(50.5);
}

prices.Sort();
prices.Reverse();

foreach (double i in prices)
    Console.WriteLine(i);

prices.Remove(50.5);

double result = prices.Find(x => x > 2000);
Console.WriteLine("Found: " + result);