using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
	public class Lexema
	{
		public static bool Nunber(string text)
		{
			int x;
			return Int32.TryParse(text, out x);
		}

		public static bool Variable(string text)
        {
			bool variable = true;
            if (text.Length == 0 || !Char.IsLetter(text[0]))
            {
                variable = false;
            }
            else
            {
				foreach (char i in text)
                {
                    if (!Char.IsDigit(i) && !Char.IsLetter(i))
                    {
                        variable = false;
                    }
                }
            }
            return variable;
        }

        public static bool ArOperator(string text)
        {
            return (text == "*" || text == "/" || text == "div" 
                || text == "mod" || text == "and" || text == "or"
                || text == "+" || text == "-" || text == "=" 
                || text == "<" || text == ">" || text == "<>" 
                || text == "<=" || text == ">=" || text == "in" || text == "not" );
        }

        public static bool ReserveWords (string text)
        {
            return (text == "array" || text == "var" || text == "type");
        }
        public static bool Comments(string text)
        {
            return (text == "//");
        }


    }

}
