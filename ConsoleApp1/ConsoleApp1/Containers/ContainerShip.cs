using ConsoleApp1.Containers;

namespace ConsoleApp1.Containers;

public class ContainerShip
{
    protected List<Container> listOfContainers { get; set; }
    protected double maxSpeed { get; set; }
    protected int maxAmountOfContainers { get; set; }
    protected double maxWeightOfContainers { get; set; }

    public ContainerShip( double maxSpeed, int maxAmountOfContainers, double maxWeightOfContainers)
    {
        listOfContainers = new List<Container>();
        this.maxSpeed = maxSpeed;
        this.maxAmountOfContainers = maxAmountOfContainers;
        this.maxWeightOfContainers = maxWeightOfContainers;
    }

    public void addContainer(Container container)
    {
        listOfContainers.Add(container);
    }

    public void addContainers(List<Container> containers)
    {
        listOfContainers.AddRange(containers);
    }


    public void removeContainer(Container container)
    {
        listOfContainers.Remove(container);
    }

    public void unloadConteinerShip()
    {
        listOfContainers.Clear();
    }

    public void changeContainer(string number, Container container)
    {
        
       foreach (var VARIABLE in listOfContainers)
       {
           if (VARIABLE.serialNumber == number)
           {
               int tmp = listOfContainers.IndexOf(VARIABLE);
               listOfContainers[tmp] = container;
               break;
           }
       }
        
    }

    public void moveContainerToAnotherContainerShip(Container container, ContainerShip containerShip)
    {
        containerShip.addContainer(container);
        listOfContainers.Remove(container);
    }

    public void infoAboutContainerShip()
    {
        Console.WriteLine("max speed: " + maxSpeed);
        Console.WriteLine("max amount Of Containers: " + maxAmountOfContainers);
        Console.WriteLine("max weight Of Containers: " + maxWeightOfContainers);
        
        
        Console.WriteLine("All of containers: ");
        foreach (var VARIABLE in listOfContainers)
        {
            Console.WriteLine(VARIABLE);
        }
    }

    public void infoAboutContainer(Container container)
    {
        
    }
}