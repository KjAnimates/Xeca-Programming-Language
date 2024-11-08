using System;
using System.Text.RegularExpressions;

namespace Xeca;

public class Lexer
{
    public Regex regex = new (@"([\s\+\-\.\=\{\}\[\]\(\);])");

    public string[] Lex (string Code) {
        return regex.Split(Code);
    }
}