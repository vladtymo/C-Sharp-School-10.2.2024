// масиви 

int[] staticArray = { 1, 2, 3, 4, 5 };

staticArray[0] = 777;
Console.WriteLine("Array Lenght: " + staticArray.Length);

// списки - динамічні колекції
List<string> students = new() { "Andrii", "Eugen", "Ivan", "Eva", "Ksenia", "Lera" };

Console.WriteLine("Array Lenght: " + students.Count);

students.Add("Volodia");
students.Insert(1, "Alex");

//foreach (var i in students) Console.WriteLine(i);
Console.WriteLine("Inserted: " + string.Join(", ", students));

students.Remove("Alex");
students.RemoveAt(0);

Console.WriteLine("Removed: " + string.Join(", ", students));

if (students.Contains("Alex"))
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Student Alex found!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Student Alex not found!");
}
Console.ResetColor();

students.Sort();
Console.WriteLine("Sorted: " + string.Join(", ", students));

students.Reverse();
Console.WriteLine($"Reversed: {string.Join(", ", students)}");

Console.WriteLine($"Starts with 'S': {students.Exists(x => x[0] == 'S')}");
Console.WriteLine($"Length <= 3: {students.Exists(x => x.Length <= 3)}");

var student = students.Find(x => x.Contains('z'));
Console.WriteLine("Name with 'Z'" + student);