using ConsoleApp1.Exception;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Containers;

public abstract class  Container : IContainer
{
    private double loadWeight { get; set; }
    private double height { get; set; }
    private double weight { get; set; }
    private double dept { get; set; }
    private string serialNumber { get; set; }
    private static int counter { get; set; }
    private double maxWeight { get; set; }
    
    
    protected Container(double loadWeight, double height, double weight, double dept, string serialNumber, double maxWeight)
    {
        this.loadWeight = loadWeight;
        this.height = height;
        this.weight = weight;
        this.dept = dept;
        this.serialNumber = "KON-";
        this.maxWeight = maxWeight;
        counter++;

    }

    public void load(double d)
    {
        loadWeight += weight;
        if (loadWeight > maxWeight)
        {
            throw new OverfillException();
        }
    }

    public void unload()
    {
        weight = 0;
        
    }
    
}