// Завдання: 
//// Користувач вводить розхід авто (л/100км) та відстань. Визначити ціну поїздки.
//Console.WriteLine("Enter your car consumption (l/100km): ");
//float consumption = float.Parse(Console.ReadLine());

//Console.WriteLine("Enter your trip distance (km): ");
//float distance = float.Parse(Console.ReadLine());

//const decimal fuelPrice = 55;

//decimal price = (decimal)((distance / 100 * consumption) * (float)fuelPrice);
//Console.WriteLine($"Trip price: {price}uah");

// арифметичні оператори: + - * /
// логічні оператори: > < >= <= == !=

/* Завдання
Користувач вводить вік. Визначити він може він навчатися в академії ШАГ.
Вік студентів від 15 до 55 років*/

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

// && (і) || (або)

if(age >= 15 && age <= 55)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You can study in STEP!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("You can not study in STEP!");
    Console.ResetColor();
}