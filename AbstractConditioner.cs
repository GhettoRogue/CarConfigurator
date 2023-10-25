namespace CarConfiguratorApp;

public abstract class AbstractConditioner : Option
{
    public double Power { get; init; }

    protected AbstractConditioner(string name, string manufacturer, double price, double power) : base(name, manufacturer, price)
    {
        Power = power;
    }
}