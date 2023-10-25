namespace CarConfiguratorApp;

public abstract class AbstractTrunk : Option
{
    public double Weight { get; init; }

    protected AbstractTrunk(string name, string manufacturer, double price, double weight) : base(name, manufacturer, price)
    {
        Weight = weight;
    }
}