using System.Threading.Channels;

interface ICar
{
    int Speed { get; set; }
    bool HighBeamOn { get; set; }
    string Color { get; set; }
    
    void Run();
    void Stop();
    void TurnLeft();
    void TurnRight();
}

class SportCar : ICar
{
    public int Year { get; set; }
    public int Speed { get; set; }
    public bool HighBeamOn { get; set; }
    public string Color { get; set; }

    public SportCar()
    {
        Color = "White";
        Speed = 0;
        HighBeamOn = false;
        Year = DateTime.Now.Year;
    }
    public void Run()
    {
        Console.WriteLine("Sport car is driving now!");
        Speed += 15;
        
        if (Speed > 100)
            HighBeamOn = true;
    }

    public void Stop()
    {
        Console.WriteLine("Sport car is stopping...");
        Speed -= 30;
    }

    public void ShowInfo()
    {
        Console.WriteLine("---------- Sport Car ----------");
        Console.WriteLine("Year: " + Year);
        Console.WriteLine("Speed: " + Speed + "km/h");
        Console.WriteLine("Color: " + Color);
        Console.WriteLine($"Lights Mode: {(HighBeamOn ? "High" : "Low")}");
    }

    public void TurnLeft()
    {
        Console.WriteLine("Sport car is turning left now!");
    }

    public void TurnRight()
    {
        Console.WriteLine("Sport car is turning right now!");
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        SportCar car = new SportCar();
        
        car.Run();
        car.Run();
        car.ShowInfo();
        
        car.TurnLeft();
        car.TurnRight();
        car.Stop();
        car.ShowInfo();
    }
}
