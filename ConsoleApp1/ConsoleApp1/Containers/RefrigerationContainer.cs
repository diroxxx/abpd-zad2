namespace ConsoleApp1.Containers;

public class RefrigerationContainer: Container
{
    private string productType;
    private double tempOfContainer;
    private double tempOfproductType;


    public RefrigerationContainer(double loadWeight, double height, double weight, double dept, double maxWeight, string productType, double tempOfContainer, double tempOfproductType) : base(loadWeight, height, weight, dept, maxWeight)
    {
        this.productType = productType;
        this.tempOfContainer = tempOfContainer;
        this.tempOfproductType = tempOfproductType;
        if (tempOfContainer < tempOfproductType )
        {
            throw new System.Exception("temperature of container cannot be lower than temperature of product");
        }
        serialNumber += "C-" + number;

    }

    public override string ToString()
    {
        return base.ToString() + $"product type: {productType}\ntemperature inside container: {tempOfContainer}\ntemperature of product type: {tempOfproductType}";
    }
}