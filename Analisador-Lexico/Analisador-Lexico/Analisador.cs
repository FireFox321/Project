using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Lexico
{
    class Analisador
    {
        void Analisar(string codigoFonte)
        {
            Fonte FonteAtual = new Fonte(codigoFonte);
            while (!FonteAtual.Eof)
            {
                Automato Aut = new Automato();
                while (!Aut.EstadoFinal) Aut.Transicao();
            }

        }
    }
}
