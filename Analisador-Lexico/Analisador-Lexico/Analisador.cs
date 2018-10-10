using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Lexico
{
    class Analisador
    {
        public string[] Analisar(char[] caracter)
        {
            int pos = 0;          //posição atual na lsita
            int estado = 0;      //define no diagrama onde estamos atualmente
            string lexema = ""; //cocatenador de caracteres
            

            while (pos != caracter.Length)
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

                            case Op1(caracter[pos]) == true:
                                lexema += caracter[pos];
                                estado = 7;
                                pos++;
                                break;

                            default:
                                estado = 0;
                                pos++;
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
                                lexe
                        }
                    break;


                case 2:
                    break;


                case 3:
                    break;


                case 4:
                    break;


                case 5:
                    break;


                case 6:
                    break;


                case 7:
                    break;


                case 8:
                    break;


                default:
                    estado = 0;

                    break;
            }
        }
    }
}
