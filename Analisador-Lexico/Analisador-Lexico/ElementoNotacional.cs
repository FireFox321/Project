using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Lexico
{
    class ElementoNotacional
    {
        readonly int linha;
        readonly int coluna;
        StringBuilder Texto ;

        public ElementoNotacional(Fonte f)
        {
            linha = f.Linha;
            coluna = f.Coluna;
        }
    }
}
