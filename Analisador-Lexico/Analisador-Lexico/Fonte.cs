using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Lexico
{
    class Fonte
    {
        bool eof => pos >= arrayFonte.Length;
        internal int linha { get; private set; }
        internal int coluna { get; private set; }
        int pos;
        char[] arrayFonte;
        public Fonte(string fonte)
        {
            arrayFonte = fonte.ToCharArray();
            pos = 0;
            linha = 1;
            coluna = 1;
        }
        public void Avancar()
        {
            if (!eof)
            {

                // hipotese: troca de linha e sempre \r\n
                if (CAtual == '\n')
                {
                    linha++;
                    coluna = 1;
                }
                pos++;
            }
        }
        char CAtual { get { return arrayFonte[pos]; } }
        char p2 => arrayFonte[pos];
    }
}
