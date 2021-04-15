using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string text = "";
            //string Namelex = "";
            int Count = 0;
            Dictionary<string, string> NameLex = new Dictionary<string, string>(); ;

            foreach ( char i in str + " ")
            {
                if (Lexema.Nunber(text) && (i == ' '|| i == ' ' || i == ';' || i == ')' || i == '+' || i == '-' || i == '*' || i == '/' || i == '='))
                {
                    Count++;
                    NameLex.Add(Count.ToString() + "-" + text, "Number");
                    text = "";
                }

                else if (Lexema.Variable(text)
                    && !Lexema.ArOperator(text)
                    && !Lexema.ReserveWords(text)
                    && (i == ' ' || i == ';' || i == '+' || i == '-' || i == '*' || i == '/' || i == '='))
                {
                    Count++;
                    NameLex.Add(Count.ToString() + "-" + text, "Variable");
                    text = "";
                }

                else if (Lexema.ArOperator(text) 
                    && (i == ' ' || i == '(' || Char.IsDigit(i) || Char.IsLetter(i)))
                {
                    Count++;
                    NameLex.Add(Count.ToString() + "-" + text, "Аrithmetic Оperator");
                    text = "";
                }

                else if (Lexema.ReserveWords(text) && (i == ' '))
                {
                    Count++;
                    NameLex.Add(Count.ToString() + "-" + text, "Reserved Words");
                    text = "";
                }

                else if (Lexema.Comments(text) && (i == ' '))
                {
                    Count++;
                    NameLex.Add(Count.ToString() + "-" + text, "Reserved Words");
                    text = "";
                }

                else if (Lexema.Semicolon(text))
                {
                    Count++;
                    NameLex.Add(Count.ToString() + "-" + text, "Semicolon");
                    text = "";
                }

                else if (text == Environment.NewLine || text == " ")
                {
                    text = "";
                }
                else if(!Lexema.Variable(text)
                    && !Lexema.ArOperator(text)
                    && !Lexema.ReserveWords(text)
                    && !Lexema.Nunber(text)
                    && !Lexema.Comments(text)
                    && !Lexema.Semicolon(text) && (i == ' '||i == ' ' || i == ';' || i == '+' || i == '-' || i == '*' || i == '/' || i == '='))
                {
                    NameLex.Add(Count.ToString() + "-" + text, "Errors");
                    text = "";
                }
                
                text += i;
            }

            foreach (KeyValuePair<string, string> pair in NameLex)
            {
                Console.WriteLine(pair.Key.PadRight(20) + " " + pair.Value);               
            }
    
            Console.ReadKey();

        }
    }
}
