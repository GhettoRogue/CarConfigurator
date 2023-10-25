namespace CarConfiguratorApp;

public class TrunkTwo : AbstractTrunk
{
    private static double weight = 2;
    public TrunkTwo(string name, string manufacturer, double price) : base(name, manufacturer, price, weight)
    {
    }
}