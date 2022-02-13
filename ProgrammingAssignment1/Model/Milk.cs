public class Milk
{
    private string type;
    private string name;
    private string brand;

    public Milk() { }
    public Milk(string type, string name, string brand)
    {
        Type = type;
        Name = name;
        Brand = brand;
    }

    public string Type { get => type; set => type = value; }
    public string Name { get => name; set => name = value; }
    public string Brand { get => brand; set => brand = value; }
}