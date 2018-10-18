using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Lexico
{
    class Fonte
    {
        internal int Linha { get; private set; }
        internal int Coluna { get; private set; }
        int pos;
        public bool Eof => pos >= arrayFonte.Length;
        public char CAtual => arrayFonte[pos];
        char[] arrayFonte;
        public Fonte(string fonte)
        {
            arrayFonte = fonte.ToCharArray();
            pos = 0;
            Linha = 1;
            Coluna = 1;
        }
        public void Avancar()
        {
            if (!Eof)
            {

                // hipotese: troca de linha e sempre \r\n
                if (CAtual == '\n')
                {
                    Linha++;
                    Coluna = 1;
                }
                pos++;
            }
        }
    }
}
