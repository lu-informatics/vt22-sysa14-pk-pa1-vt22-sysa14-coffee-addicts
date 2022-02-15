public class Coffee
{
    private string name;    
    private string beansEAN;
    private int beanWeightGram;
    private int grindSize;
    private string waterSize;

    public Coffee() { }

    public Coffee(string name, int grindSize, string beansEAN, string waterSize, int beanWeightGram)
    {
        Name = name;
        GrindSize = grindSize;
        BeansEAN = beansEAN;
        WaterSize = waterSize;
        BeanWeightGram = beanWeightGram;
    }

    public string Name { get => name; set => name = value; }
    public int GrindSize { get => grindSize; set => grindSize = value; }
    public string BeansEAN { get => beansEAN; set => beansEAN = value; }
    public string WaterSize { get => waterSize; set => waterSize = value; }
    public int BeanWeightGram { get => beanWeightGram; set => beanWeightGram = value; }

    public string TableToString()
    {
        return "Coffee";
    }


}