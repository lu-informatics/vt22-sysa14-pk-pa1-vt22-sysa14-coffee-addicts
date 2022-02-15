public class Milk
{
    private string variety;
    private string brand;

    public Milk(string variety, string brand)
    {
        this.Variety = variety;
        this.Brand = brand;
    }

    public string Variety { get => variety; set => variety = value; }
    public string Brand { get => brand; set => brand = value; }
}