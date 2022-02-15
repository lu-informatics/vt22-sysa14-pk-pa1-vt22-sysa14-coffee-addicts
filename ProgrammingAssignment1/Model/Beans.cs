public class Beans
{
    private string EAN;
    private string roast;
    

    public Beans() { }

    public Beans(string ean, string roast)
    {
        Roast = roast;
        EAN1 = ean;
    }

    public string Roast { get => roast; set => roast = value; }
    public string EAN1 { get => EAN; set => EAN = value; }





}