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

string goodExp = "2 + (1 * [1:1] + x) { ( 44 + 4 [9-9] ) }";
string badExp = "2 + (1 * {1:1] + x)) { [ 44 + 4 [9-9] ) })";

void CheckExp(string exp)
{
    Dictionary<char, char> dict = new Dictionary<char, char>()
    {
        // ключ = значення
        [')'] = '(',
        [']'] = '[',
        ['}'] = '{'
    };
    
    Stack<char> brackets = new();

    foreach (var s in exp)
    {
        if (dict.ContainsValue(s))
            brackets.Push(s);

        if (dict.ContainsKey(s))
        {
            if (brackets.Pop() != dict[s])
            {
                Console.WriteLine("Expression is invalid!");
                return;
            }
        }
    }

    if (brackets.Count == 0)
        Console.WriteLine("Expression is correct");
    else
        Console.WriteLine("Expression is incorrect");
}

CheckExp("(2 + [1+1])");
CheckExp(goodExp);
CheckExp(badExp);
