public class Modifier
{
    private string name;
    private int temperature;
    private string foam;

    public Modifier() { }

    public Modifier(string name, int temperature, string foam)
    {
        Name = name;
        Temperature = temperature;
        Foam = foam;
    }

    public string Name { get => name; set => name = value; }
    public int Temperature { get => temperature; set => temperature = value; }
    public string Foam { get => foam; set => foam = value; }
}