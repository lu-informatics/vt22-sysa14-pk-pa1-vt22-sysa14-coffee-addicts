public class Beverage
{

    private string bevName;
    private string coffeeName;
    private string foamType;
    private string milkVariety;

    public Beverage(string bevName, string coffeeName, string foamType, string milkVariety)
    {
        this.bevName = bevName;
        this.coffeeName = coffeeName;
        this.foamType = foamType;
        this.milkVariety = milkVariety;
    }

    public string BevName { get => bevName; set => bevName = value; }
    public string CoffeeName { get => coffeeName; set => coffeeName = value; }
    public string FoamType { get => foamType; set => foamType = value; }
    public string MilkVariety { get => milkVariety; set => milkVariety = value; }
}