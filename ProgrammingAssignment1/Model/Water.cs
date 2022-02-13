public class Water
{
    private string size;
    private int volumeML;

    public Water() { }
    public Water(string size, int volumeML)
    {
        Size = size;
        VolumeML = volumeML;
    }

    public string Size { get => size; set => size = value; }
    public int VolumeML { get => volumeML; set => volumeML = value; }
}