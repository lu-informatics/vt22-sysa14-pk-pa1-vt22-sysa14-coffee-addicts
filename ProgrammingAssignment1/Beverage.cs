public class Beverage
{
    private string proccessMilkType;
    private string coffeeName;
    private string bevName;
    private string coffeeBeansEAN;
    private string coffeeWaterSize;
    private string proccessModifierName;

    public Beverage() { }

    public Beverage(string proccessMilkType, string coffeeName, string bevName, string coffeeBeansEAN, string coffeeWaterSize, string proccessModifierName)
    {
        ProccessMilkType = proccessMilkType;
        CoffeeName = coffeeName;
        BevName = bevName;
        CoffeeBeansEAN = coffeeBeansEAN;
        CoffeeWaterSize = coffeeWaterSize;
        ProccessModifierName = proccessModifierName;
    }


    public string ProccessMilkType { get => proccessMilkType; set => proccessMilkType = value; }
    public string CoffeeName { get => coffeeName; set => coffeeName = value; }
    public string BevName { get => bevName; set => bevName = value; }
    public string CoffeeBeansEAN { get => coffeeBeansEAN; set => coffeeBeansEAN = value; }
    public string CoffeeWaterSize { get => coffeeWaterSize; set => coffeeWaterSize = value; }
    public string ProccessModifierName { get => proccessModifierName; set => proccessModifierName = value; }
}