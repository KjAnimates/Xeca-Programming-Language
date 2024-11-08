using System;
using System.Text.RegularExpressions;

namespace Xeca;

public class Lexer
{
    public Regex regex = new(@"([!\s\+\-\.\=\{\}\[\]\(\);"",])");

    public Token[] Lex (string Code) {
        Token[] tokens = [];
        string[] rawTokens = regex.Split(Code);

        foreach (string rawToken in rawTokens)
        {
            if(string.IsNullOrWhiteSpace(rawToken))
                continue;
            
            Token token = new();
            token.Value = rawToken;

            // Figure out the type
            string t = rawToken.Trim();

            switch(t)
            {
                case "(":
                    token.Type = TokenType.PAREN_OPEN;
                    break;
                case ")":
                    token.Type = TokenType.PAREN_CLOSE;
                    break;
                case "\"":
                    token.Type = TokenType.QUOTE;
                    break;
                case ".":
                    token.Type = TokenType.PERIOD;
                    break;
                case "[":
                    token.Type = TokenType.BRACKET_OPEN;
                    break;
                case "]":
                    token.Type = TokenType.BRACKET_CLOSE;
                    break;
                case "{":
                    token.Type = TokenType.CURLY_OPEN;
                    break;
                case "}":
                    token.Type = TokenType.CURLY_CLOSE;
                    break;
                case ",":
                    token.Type = TokenType.COMMA;
                    break;
                case ";":
                    token.Type = TokenType.SEMICOLON;
                    break;
                default:
                    token.Type = TokenType.WORD;
                    break;
            }

            tokens = [.. tokens, token];
        }

        return tokens;
    }
}