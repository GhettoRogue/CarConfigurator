namespace CarConfiguratorApp;

public class TrunkOne : AbstractTrunk
{
    private static double weight = 1;
    public TrunkOne(string name, string manufacturer, double price) : base(name, manufacturer, price, weight)
    {
    }
}