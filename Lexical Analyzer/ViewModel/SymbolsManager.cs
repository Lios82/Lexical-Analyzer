using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lexical_Analyzer.Model;

namespace Lexical_Analyzer.ViewModel
{
    class SymbolsManager
    {
        public List<Symbols> symbols;

        public SymbolsManager()
        {
            symbols = new List<Symbols>();
            MakeSymbolList();
        }

        private void MakeSymbolList()
        {
            symbols.Add(new Symbols { Id = 0, Data = "(", Category = "Bracket" });
            symbols.Add(new Symbols { Id = 0, Data = ")", Category = "Bracket" });
            symbols.Add(new Symbols { Id = 0, Data = "{", Category = "Bracket" });
            symbols.Add(new Symbols { Id = 0, Data = "}", Category = "Bracket" });
            symbols.Add(new Symbols { Id = 0, Data = "[", Category = "Bracket" });
            symbols.Add(new Symbols { Id = 0, Data = "]", Category = "Bracket" });

            symbols.Add(new Symbols { Id = 0, Data = "<", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = ">", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "<=", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = ">=", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "!=", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "|", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "&", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "!", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "==", Category = "Logical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = ">", Category = "Logical Operator" });

            symbols.Add(new Symbols { Id = 0, Data = "+", Category = "Mathematical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "-", Category = "Mathematical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "*", Category = "Mathematical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "/", Category = "Mathematical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "=", Category = "Mathematical Operator" });
            //symbols.Add(new Symbols { Id = 0, Data = "-", Category = "Mathematical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "++", Category = "Mathematical Operator" });
            symbols.Add(new Symbols { Id = 0, Data = "--", Category = "Mathematical Operator" });
        }
    }
}
