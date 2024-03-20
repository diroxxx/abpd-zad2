using ConsoleApp1.Interface;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool isDangerous { get; set; }
    public LiquidContainer(double loadWeight, double height, double weight, double dept, double maxWeight, bool isDangerous) : base(loadWeight, height, weight, dept, maxWeight)
    {
        serialNumber += "L-" + number;
        this.isDangerous = isDangerous;

    }


    public void SendText(string number)
    {
        Console.WriteLine("Something bad happend with container: " + number);
    }

    public override void load(double d)
    {
        if (isDangerous)
        {
           maxWeight = maxWeight * 0.5;
           if ( d + loadWeight < maxWeight)
           {
               loadWeight += d;
           }
           else
           {
               SendText(serialNumber);
           }
        }
        else
        {
            maxWeight = maxWeight * 0.9;
            if ( d + loadWeight < maxWeight)
            {
                loadWeight += d;
            }
            else
            {
                 SendText(serialNumber);
            }
                
            
        }
        
        
    }

    public override string ToString()
    {
        return base.ToString() + "is dangerous:  " + isDangerous;
    }
}