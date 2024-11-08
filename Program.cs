using System;

namespace Xeca;

public class Program
{
    public static void Main(String[] Args)
    {
        CommandArg[] commandArgs = CLI.GetInputs(Args);

        if(commandArgs.Length > 0)
        {
            // Compile the code ig?
        }
        else
        {
            CLI.Run();
        }
    }
}