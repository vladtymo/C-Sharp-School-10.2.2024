Stack<string> stack = new Stack<string>();

stack.Push("Volodia");
stack.Push("Lera");
stack.Push("Andrii");
stack.Push("Eugen");
stack.Push("Maks");

Console.WriteLine("Top item: " + stack.Peek()); // показати верхній елемент

Console.WriteLine("Top item: " + stack.Pop()); // повернути та видалити верхній елемент

Console.WriteLine("Students" + stack.Count); // 4

Console.WriteLine("Maks: " + stack.Contains("Maks"));

Console.WriteLine("Students:");
// поки елементи є
while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}

