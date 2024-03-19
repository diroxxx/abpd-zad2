namespace ConsoleApp1.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double loadWeight, double height, double weight, double dept, string serialNumber, double maxWeight) : base(loadWeight, height, weight, dept, serialNumber, maxWeight)
    {
    }

    public virtual void load(double d)
    {
        
    }

    public void unload()
    {
        
    }

}