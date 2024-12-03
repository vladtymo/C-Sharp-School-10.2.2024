// Робота з масивами

int price1 = 1200;
int price2 = 24;
int price3 = 3300;
int price4 = 999;

//Console.WriteLine(price1 + price2);

// створення масиву

int[] prices = [ 120, 99, 44, 567, 561 ];

string[] colors = { "red", "blue", "green", "yellow", "yellow" };

colors[0] = "black";

// індекс елементів починається з 0
prices[0] = 330;

//Console.WriteLine(prices[0]);
//Console.WriteLine(prices[1]);
//Console.WriteLine(prices[2]);
//Console.WriteLine(prices[3]);

Console.WriteLine("Prices: " + prices.Length);

Console.WriteLine("-------- for loop --------");
for (int i = 0; i < prices.Length; ++i)
{
    // code...
    Console.WriteLine(prices[i]);
}

int[,] map = new int[3, 4]
{
    { 3, 4, 10, 340 },
    { 99, 1, 9, 34 },
    { 10, 0, 0, 4 }
};

Console.WriteLine(map[0, 0]); // 3
Console.WriteLine(map[1, 2]); // 9

Console.WriteLine("------------ Map ------------");

for (int row = 0; row < 3; row++)
{
    for (int col = 0; col < 4; col++)
    {
        Console.Write(map[row, col] + " ");
    }
    Console.WriteLine();
}