using System;

namespace Xeca;

public class Program
{
    public static void Main(String[] Args)
    {
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
                    switch(Flag)
                    {
                        case "-i":
                            Console.WriteLine("Input  = " + Value);
                            break;
                        case "-o":
                            Console.WriteLine("Output = " + Value);
                            break;
                    }
                }
            }
        }
    }
}