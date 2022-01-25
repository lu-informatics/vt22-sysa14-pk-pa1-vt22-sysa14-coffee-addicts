public class Process
{

    private string modifierName;
    private string milkType;

    public Process() { }

    public Process(string modifierName, string milkType)
    {
        ModifierName = modifierName;
        MilkType = milkType;
    }

    public string ModifierName { get => modifierName; set => modifierName = value; }
    public string MilkType { get => milkType; set => milkType = value; }

    
}