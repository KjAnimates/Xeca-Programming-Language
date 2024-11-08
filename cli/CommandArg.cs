namespace Xeca;
public class CommandArg
{
    public string? Flag;
    public string? Value;

    public CommandArg() { }
    
    public CommandArg(string Flag, string Value)
    {
        this.Flag = Flag;
        this.Value = Value;
    }

}