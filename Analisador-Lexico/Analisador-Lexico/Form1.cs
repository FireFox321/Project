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
            lbLexemas.Items.Clear();
            //Consegui usar o Github no VS :-D
            char[] caracter = rtbInput.Text.ToCharArray();

            #region Analisador
            int linha = 1;
            int coluna = 1;
            int pos = 0;          //posição atual na lsita
            int estado = 0;      //define no diagrama onde estamos atualmente
            string lexema = ""; //cocatenador de caracteres

            while (pos != caracter.Length)
            {
                switch (estado)
                {
                    case 0:
                        switch (caracter[pos])
                        {
                            case ' ':
                                pos++;
                                estado = 0;
                                break;

                            case '/':
                                lexema += caracter[pos];
                                estado = 1;
                                pos++;
                                break;

                            default:
                                if (Operadores.Op1(caracter[pos]))
                                {
                                    lexema += caracter[pos];
                                    estado = 7;
                                    pos++;

                                }
                                else
                                {
                                    if (caracter[pos] == '\n')
                                    {
                                        linha++;
                                        coluna = 0;
                                    }
                                    
                                    //acumular o que não é problema nosso
                                    estado = 0;
                                    pos++;
                                }
                                break;
                        }
                        break;

                    case 1:
                        switch (caracter[pos])
                        {
                            case '/':
                                lexema += caracter[pos];
                                estado = 2;
                                pos++;
                                break;

                            case '*':
                                lexema += caracter[pos];
                                estado = 4;
                                pos++;
                                break;

                            default:
                                if (Operadores.Op2(caracter[pos - 1], caracter[pos]))
                                {
                                    lexema += caracter[pos];
                                    estado = 7;
                                    pos++;

                                }
                                else
                                {
                                    if (caracter[pos] == '\n')
                                    {
                                        linha++;
                                        coluna = 0;
                                    }
                                    lbLexemas.Items.Add("L " + linha.ToString() + " | C " + coluna.ToString() + " | " + lexema);
                                    lexema = "";
                                    estado = 0;
                                }
                                break;


                        }
                        break;


                    case 2:
                    case 3:
                        switch (caracter[pos])
                        {
                            case '\n':
                                pos++;
                                lbLexemas.Items.Add("L " + linha.ToString() + " | C " + coluna.ToString() + " | " + lexema);
                                lexema = "";
                                estado = 0;

                                linha++;
                                coluna = 0;
                                break;

                            default:
                                lexema += caracter[pos];
                                estado = 3;
                                pos++;
                                break;
                        }
                        break;

                    case 4:
                    case 5:
                        switch (caracter[pos])
                        {
                            case '*':
                                lexema += caracter[pos];
                                estado = 6;
                                pos++;
                                break;

                            default:
                                if (caracter[pos] == '\n')
                                {
                                    linha++;
                                    coluna = 0;
                                }
                                lexema += caracter[pos];
                                estado = 5;
                                pos++;
                                break;
                        }
                        break;


                    case 6:
                        switch (caracter[pos])
                        {
                            case '/':
                                lexema += caracter[pos];
                                lbLexemas.Items.Add("L " + linha.ToString() + " | C " + coluna.ToString() + " | " + lexema);
                                lexema = "";
                                estado = 0;
                                pos++;
                                break;

                            case '*':
                                lexema += caracter[pos];
                                estado = 6;
                                pos++;
                                break;

                            default:
                                if (caracter[pos] == '\n')
                                {
                                    linha++;
                                    coluna = 0;
                                }
                                lexema += caracter[pos];
                                estado = 5;
                                pos++;
                                break;
                        }
                        break;

                    case 7:
                        if (Operadores.Op2(caracter[pos - 1], caracter[pos]))
                        {
                            lexema += caracter[pos];
                            estado = 8;
                            pos++;
                        }
                        else if (caracter[pos] == '\n')
                        {
                            linha++;
                            coluna = 0;
                            pos++;
                        }
                        else
                        {
                            lbLexemas.Items.Add("L " + linha.ToString() + " | C " + coluna.ToString() + " | " + lexema);
                            lexema = "";
                            estado = 0;
                        }
                        break;

                    case 8:
                        if (Operadores.Op3(caracter[pos - 2], caracter[pos - 1], caracter[pos]))
                        {
                            lexema += caracter[pos];
                            lbLexemas.Items.Add("L " + linha.ToString() + " | C " + coluna.ToString() + " | " + lexema);
                            lexema = "";
                            estado = 0;
                            pos++;
                        }
                        else if (caracter[pos] == '\n')
                        {
                            linha++;
                            coluna = 0;
                            pos++;
                        }
                        else
                        {
                            lbLexemas.Items.Add("L " + linha.ToString() + " | C " + coluna.ToString() + " | " + lexema);
                            lexema = "";
                            estado = 0;
                        }
                        break;


                    default:
                        estado = 0;
                        break;
                }
                coluna++;
            }
            
            //quando chega aqui: EOF
            if (estado == 1 || estado == 7 || estado == 8)
            {
                lbLexemas.Items.Add("L " + linha.ToString() + " | C " + coluna.ToString() + " | " + lexema);
            }
            
            #endregion

        }
    }
}
