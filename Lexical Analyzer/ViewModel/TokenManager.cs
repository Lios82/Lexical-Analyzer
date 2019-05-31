using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexical_Analyzer.Model;

namespace Lexical_Analyzer.ViewModel
{
    class TokenManager
    {
        public List<Tokens> tokens;

        public TokenManager()
        {
            tokens = new List<Tokens>();
            MakeTokenList();
        }

        private void MakeTokenList()
        {
            tokens.Add(new Tokens { Id = 0, Data = "main", Category = "Function" });
            tokens.Add(new Tokens { Id = 0, Data = "printf", Category = "Function" });
            tokens.Add(new Tokens { Id = 0, Data = "scanf", Category = "Function" });
            tokens.Add(new Tokens { Id = 0, Data = "getch", Category = "Function" });

            tokens.Add(new Tokens { Id = 0, Data = "auto", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "break", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "case", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "char", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "const", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "return", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "continue", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "default", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "do", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "double", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "else", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "enum", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "extern", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "float", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "for", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "goto", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "if", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "int", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "long", Category = "Keyword" }); 
            tokens.Add(new Tokens { Id = 0, Data = "register", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "short", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "signed", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "unsigned", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "sizeof", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "static", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "struct", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "switch", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "typedef", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "union", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "void", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "volatile", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "while", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "include", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "stdio", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "using", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "namespace", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "std", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "iostream", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "algorithm", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "endl", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "cin", Category = "Keyword" });
            tokens.Add(new Tokens { Id = 0, Data = "cout", Category = "Keyword" });
        }
    }
}
