using ConsoleApp1.Exception;
using ConsoleApp1.Interface;

namespace ConsoleApp1.Containers;

public abstract class  Container : IContainer
{
    protected double loadWeight { get; set; }
    private double height { get; set; }
    private double weight { get; set; }
    private double dept { get; set; }
    public string serialNumber { get; set; }
    protected int number { get; set; }
    protected static int counter { get; set; }
    protected double maxWeight { get; set; }
     
    
    
    protected Container(double loadWeight, double height, double weight, double dept, double maxWeight)
    {
        this.loadWeight = loadWeight;
        this.height = height;
        this.weight = weight;
        this.dept = dept;
        serialNumber = "KON-";
        this.maxWeight = maxWeight;
        number = counter++;
    }

    public virtual void load(double d)
    {
        loadWeight += weight;
        if (loadWeight > maxWeight)
        {
            throw new OverfillException();
        }
    }

    public virtual void unload()
    {
        loadWeight = 0;
    }
    
  public override string ToString()
      {
          return
              $"-----\nload weight: {loadWeight}\nheight: {height}\nweight: {weight}\ndept: {dept}\nserial number: {serialNumber}\nmax weight: {maxWeight}\n";
      }
    
}