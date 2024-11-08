using System;
using System.Runtime.InteropServices;

namespace Xeca;
public class CLI
{
    public static void Run ()
    {
        while(true)
        {
            string? line = Console.ReadLine();
            
            if(line == ".exit")
                break;
            
        }
    }

    public static CommandArg[] GetInputs (String[] Args)
    {
        CommandArg[] commandArgs = [];

        // Check if there is an input
        // <flag> <value>
        if(Args.Length > 0) 
        {
            for(int i = 0; i < Args.Length; i++)
            {
                string arg = Args[i];
                string ? Flag = null;
                string ? Value = null;
                
                // Gets the flag and the value for the flag
                if(i % 2 == 0)
                {
                    if (i + 1 < Args.Length)
                    {
                        Flag = Args[i];
                        Value = Args[i + 1];
                    }
                }

                if(Flag != null && Value != null)
                {
                    CommandArg cmd = new(Flag, Value);

                    // Add the command argument to the array.
                    commandArgs = [.. commandArgs, cmd];
                }
            }
        }

        return commandArgs;
    }
}