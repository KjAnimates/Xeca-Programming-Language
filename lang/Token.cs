using System;

namespace Xeca;
public class Token
{
    public TokenType Type = TokenType.WORD;
    public string? Value;

    public override string ToString()
    {
        return $"[{Type.ToString()} = \"{Value}\"]";
    }
}