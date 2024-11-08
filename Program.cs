using System;

namespace Xeca;

public class Program
{
    public static void Main(String[] Args)
    {
        CommandArg[] commandArgs = CLI.GetInputs(Args);
        Lexer lexer = new();

        string code = "fn test(){ print(\"Hello, world.\"); }";
        Token[] tokens = lexer.Lex(code);

        foreach(Token token in tokens)
        {
            Console.WriteLine(token.ToString());
        }

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