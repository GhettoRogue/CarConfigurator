using System.Collections.Immutable;

namespace CarConfiguratorApp;

public class Car
{
    public CarBase CarBase { get; set; }
    private readonly Dictionary<Option, double> _options;

    public Car()
    {
        _options = new Dictionary<Option, double>();
    }

    public double CalcTotalPrice()
    {
        return CarBase.BasePrice + _options.Sum(o => o.Value);
    }

    public void AddOption(Option option)
    {
        if (option.Cars.Contains(CarBase))
        {
            _options.Add(option, option.Price);
        }
    }

    public IEnumerable<Option> GetOptions()
    {
        return _options.Keys;
    }
}