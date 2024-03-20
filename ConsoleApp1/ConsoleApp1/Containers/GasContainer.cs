using ConsoleApp1.Exception;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private double pressure { get; set; }
    public GasContainer(double loadWeight, double height, double weight, double dept, double maxWeight, double pressure) : base(loadWeight, height, weight, dept, maxWeight)
    {
        this.pressure = pressure;
        serialNumber += "G-" + number;

    }

    public override void unload()
    {
        loadWeight = loadWeight * 0.05;
    }

    public override void load(double d)
    {
        if (loadWeight > maxWeight)
        {
            throw new OverfillException();
        }
        else
        {
            loadWeight += d;
        }
    }

    public void SendText(string number)
    {
        Console.WriteLine("Something bad happend with container: " + number);
    }
    
    public override string ToString()
    {
        return base.ToString() + "pressure: " + pressure;
    }
}