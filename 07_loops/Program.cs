﻿// ---------- loops -----------
// for(змінна; умова; вираз) {}

Console.Write("Enter number: ");
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; ++i)
{
    Console.WriteLine($"{i} - Iteration");
    Console.WriteLine("Hello Eugen!");
}

Console.Write("Enter positive number: ");
int number = int.Parse(Console.ReadLine());

while (number <= 0)
{
    Console.Write("Invalid number, please enter again: ");
    number = int.Parse(Console.ReadLine());
}

string name;

do
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    
} while (!char.IsUpper(name[0]));

// вічний цикл
while (true)
{
    Console.Write("Enter password:");
    string pass = Console.ReadLine();
    
    if (pass == "admin")
        break; // завершити цикл
}

Console.WriteLine("Have a nice day!");

// Користувач вводить діапазон. Визначити кількість чисел, які кратні 7-ми.
Console.Write("Enter start: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter end: ");
int b = int.Parse(Console.ReadLine());

int num = 0; // кількість

for (int i = a; i <= b; ++i)
{
    if (i % 7 == 0)
        num++;
}

Console.WriteLine($"Знайдено чисел кратних 7-ми: {num}");