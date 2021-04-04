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
            string Namelex = "";

            foreach( char i in str + "")
            {
                text += i;
                if (Lexema.Nunber(text))
                {
                    Namelex = "Number";
                }
                else if (Lexema.Variable(text) && !Lexema.ArOperator(text) && !Lexema.ReserveWords(text))
                {
                    Namelex = "Variable";
                }
                else if (Lexema.ArOperator(text))
                {
                    Namelex = "Аrithmetic Оperator";
                }
                else if (Lexema.ReserveWords(text))
                {
                    Namelex = "Reserved Words";
                }
                else if (Lexema.Comments(text))
                {
                    Namelex = "Comments";
                }
                else
                {   
                    Namelex = "Errors";
                }

            }
            Console.WriteLine(Namelex);
            Console.ReadKey();

        }
    }
}
