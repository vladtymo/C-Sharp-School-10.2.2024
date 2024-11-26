using System.Threading.Channels;

internal class Program
{
    public static void Main(string[] args)
    {
        var dog = new Dog();

        dog.name = "James";
        dog.Jump();
        dog.SayGav();
        
    }
}

class Dog
{
    // properties
    public double weight;
    public string breed;
    public string name;
    public int age;
    public bool isSecurityGuard;

    // methods
    public void Jump()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("I am jumping...!");
        Console.ResetColor();
    }
    
    public void SayGav()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Gav-gav-gav!");
        Console.ResetColor();
    }
    
    public void Eat()
    {
        Console.WriteLine("I am eating now...!");
        weight += 0.5;
    }
}
