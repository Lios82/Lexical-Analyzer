using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lexical_Analyzer.ViewModel;
using System.Text.RegularExpressions;

namespace Lexical_Analyzer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Code, symbol, number;
        private string retrivedSymbols;
        private string mathSymbols, logicalSymbols, braces,tokens, function, keywords, identifiers;

        private SymbolsManager sManager;
        private TokenManager tManager;

        public MainWindow()
        {
            InitializeComponent();
            sManager = new SymbolsManager();
            tManager = new TokenManager();
            Code = "";
            symbol = "";
            number = "";
            mathSymbols = "";
            logicalSymbols = "";
            braces = "";
            tokens = "";
            function = keywords = identifiers = "";
        }

        private void BrowseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                FileLocation.Text = openFileDialog.FileName;
            CodeText.Text = File.ReadAllText(openFileDialog.FileName);
            RetriveCode();
            RetrivedSymbols();
            RetriveTokens();
            ClassifyTokens();
            Output();
        }

        private void RetriveCode()
        {
            Code = CodeText.Text;
        }

        private void RetrivedSymbols()
        {
            int n = Code.Length;
            string code = Code;

            for (int j = 0; j < n; j++)
            {
                if ((code[j] < 65 || code[j] > 90) && (code[j] < 97 || code[j] > 123) && (code[j] < 48 || code[j] > 58) && code[j] != 32)
                {
                    symbol += code[j];
                }
                if (code[j] > 47 && code[j] < 58)
                {
                    number += (code[j]+", ");
                }
            }
            string[] sch = symbol.Split(' ');
            string z = "";
            foreach (string x in sch)
            {
                z += x;
            }
            string[] final = z.Split('\u0009');
            string finalSymbols = "";

            foreach (string s in final)
            {
                finalSymbols += s;
            }

            retrivedSymbols = Regex.Replace(finalSymbols, @"\t|\n|\r", "");

            ClassifySymbols();
        }

        private string[] Tokens;

        private void RetriveTokens()
        {
            tokens = Regex.Replace(CodeText.Text, @"[^a-zA-Z]+", " ");
            Tokens = tokens.Split(' ');           
        }       

        private void ClassifySymbols()
        {
            var sym = sManager.symbols;
            int n = retrivedSymbols.Length;
            foreach(var s in sym)
            {
                for(int i=0;i<n;i++)
                {
                    if(s.Data==retrivedSymbols[i].ToString())
                    {
                        string tmp = s.Category;
                        if (tmp == "Bracket")
                            braces += (retrivedSymbols[i].ToString()+", ");
                        if (tmp == "Logical Operator")
                            logicalSymbols += (retrivedSymbols[i].ToString() + ", ");
                        if (tmp == "Mathematical Operator")
                            mathSymbols += (retrivedSymbols[i].ToString() + ", ");
                    }
                }
            }           
        }

        private void ClassifyTokens()
        {
            string others = "";
            int n = Tokens.Length;
            foreach(var s in tManager.tokens)
            {
                for(int i=0;i<n;i++)
                {
                    if (s.Data == Tokens[i].ToString())
                    {
                        string tmp = s.Category;
                        if (tmp == "Function")
                        {
                            function += (Tokens[i].ToString() + ", ");
                            Tokens[i] = " ";
                        }
                        if (tmp == "Keyword")
                        {
                            keywords += (Tokens[i].ToString() + ", ");
                            Tokens[i] = " ";
                        }

                    }                   
                }
            }

            for(int i=0;i<n;i++)
            {
                others += Tokens[i];
            }
            string[] OthersFinal = others.Split(' ');
            foreach(string s in OthersFinal)
            {
                identifiers += (s + ", ");
            }
        }

        private void Output()
        {
            OutputText.Text = "Mathematical Operators:\n" + mathSymbols + "\n\n" + "Logical Operators:\n" + logicalSymbols + "\n\n" + "Brackets:\n" + braces + "\n\nNumbers:\n" + number + "\n\nTokens:\n" + tokens+"\n\n\nAnd the tokens after classification comes,\n\nFunctions:\n"+function+"\n\nKeywords:\n"+keywords+"\n\nIdentifiers:\n"+identifiers;
        }
    }
}
