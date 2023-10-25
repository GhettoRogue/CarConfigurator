using CarConfiguratorApp;

var dict = new Dictionary<Type, string>()
{
    {typeof(AbstractTrunk), "багажник"},
    {typeof(AbstractConditioner), "кондиционер"}
};

var ladaSedanBase = new CarBase()
{
    Model = "Seven",
    Brand = "Lada",
    Manufacturer = "VAZ",
    BasePrice = 100
};
var nivaBase = new CarBase()
{
    Model = "Legend",
    Brand = "Niva",
    Manufacturer = "VAZ",
    BasePrice = 1000
};

var ladaSedan = new Car()
{
    CarBase = ladaSedanBase
};

var niva = new Car()
{
    CarBase = nivaBase
};

var con1 = new ConditionerOne("One", "Z", 20);
con1.AddCar(ladaSedanBase);

var con2 = new ConditionerTwo("Two", "Z", 200);
con2.AddCar(ladaSedanBase);
con2.AddCar(nivaBase);

var trunk1 = new TrunkOne("T1", "V", 10);
trunk1.AddCar(ladaSedanBase);
trunk1.AddCar(nivaBase);

var trunk2 = new TrunkOne("T2", "V", 10);
trunk2.AddCar(ladaSedanBase);
trunk2.AddCar(nivaBase);

ladaSedan.AddOption(con1);
ladaSedan.AddOption(trunk1);
PrintCar(ladaSedan, dict);
Console.WriteLine(ladaSedan.CalcTotalPrice());

niva.AddOption(con1);
niva.AddOption(trunk2);
PrintCar(niva, dict);
Console.WriteLine(niva.CalcTotalPrice());

return;

void PrintOptionInfo(Option option, Dictionary<Type, string> dict)
{
    Console.WriteLine($"{dict[option.GetType().BaseType]} {option.Name} {option.Price}");
}

void PrintCar(Car car, Dictionary<Type, string> dict)
{
    Console.WriteLine($"{car.CarBase.Brand} {car.CarBase.Model} {car.CarBase.BasePrice}");
    foreach (var option in car.GetOptions())
    {
        PrintOptionInfo(option, dict);
    }
}