namespace CarConfiguratorApp;

public class ConditionerOne : AbstractConditioner
{
    private static double power = 1;
    public ConditionerOne(string name, string manufacturer, double price) : base(name, manufacturer, price, power)
    {
    }
}