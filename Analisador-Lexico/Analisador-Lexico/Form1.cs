using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisador_Lexico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            char[] texto = rtbInput.Text.ToCharArray();

            bool op1 = false;
            bool op2 = false;
            bool op3 = false;

            char caracter_anterior = ' ';


            foreach (char caracter in texto)
            {

                if (op2) op3 = Operadores.Op3(caracter_anterior, caracter);
                if (op1) op2 = Operadores.Op2(caracter_anterior, caracter);
                op1 = Operadores.Op1(caracter);

                caracter_anterior = caracter;
            }
        }
    }
}
