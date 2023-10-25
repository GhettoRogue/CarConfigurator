namespace CarConfiguratorApp;

public class ConditionerTwo : AbstractConditioner
{
    private static double power = 2;
    public ConditionerTwo(string name, string manufacturer, double price) : base(name, manufacturer, price, power)
    {
    }
}