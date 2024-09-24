// Завдання: 
// Користувач вводить розхід авто (л/100км) та відстань. Визначити ціну поїздки.
Console.WriteLine("Enter your car consumption (l/100km): ");
float consumption = float.Parse(Console.ReadLine());

Console.WriteLine("Enter your trip distance (km): ");
float distance = float.Parse(Console.ReadLine());

const decimal fuelPrice = 55;

decimal price = (decimal)((distance / 100 * consumption) * (float)fuelPrice);
Console.WriteLine($"Trip price: {price}uah");