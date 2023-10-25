namespace CarConfiguratorApp;

public abstract class Option
{
    public string Name { get; init; }
    public string Manufacturer { get; init; }
    public double Price { get; init; }
    public List<CarBase> Cars { get; init; }

    protected Option(string name, string manufacturer, double price)
    {
        Name = name;
        Manufacturer = manufacturer;
        Price = price;

        Cars = new List<CarBase>();
    }

    public void AddCar(CarBase carBase)
    {
        Cars.Add(carBase);
    }
}