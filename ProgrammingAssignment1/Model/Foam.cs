public class Foam
{
    private string type;
    private int temperature;
    private int time;

    public Foam(string type, int temperature, int time)
    {
        this.type = type;
        this.temperature = temperature;
        this.time = time;
    }

    public string Type { get => type; set => type = value; }
    public int Temperature { get => temperature; set => temperature = value; }
    public int Time { get => time; set => time = value; }
}