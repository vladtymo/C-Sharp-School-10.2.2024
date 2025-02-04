public class Drone
{
    public string model;
    public int screws;
    public double height;
    public double distance;
    public bool hasCamera;

    public void TakePhoto()
    {
        if (hasCamera)
            Console.WriteLine("Taking a photo!");
        else
            Console.WriteLine("No camera!");
    }
    
    public void Fly()
    {
        if (height < 100)
            height += 10;
        
        Console.WriteLine($"Flying on height {height}m!");
    }
    
    public void Stop()
    {
        height = 0;
        Console.WriteLine($"Stopped! Actual height: {height}m!");
    }

    public void PrintInfo()
    {
        Console.WriteLine("Model: " + model);
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Drone drone = new Drone();
        
        drone.TakePhoto();
        drone.Fly();
        drone.Stop();
        drone.PrintInfo();
    }
}