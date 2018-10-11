using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Lexico
{
    class Operadores
    {
        public static bool Op1(char c1)
        {

            switch (c1)
            {
                case '+':
                    return true;
                case '-':
                    return true;

			default:
                    return false;
            }
        }

        public static bool Op2(char c1,char c2)
        {

            switch (c1)
            {
                case '+':
                    return (c2 == '+' | c2 == '=');
                case '-':
                    return (c2 == '-' | c2 == '=');

			default:
                    return false;
            }
        }

        public static bool Op3(char c1, char c2, char c3)
        {

            switch (c2)
            {
                case '<':
                    return (c3 == '<');
                case '>':
                    return (c2 == '>');

			default:
                    return false;
            }
        }
    }
}
