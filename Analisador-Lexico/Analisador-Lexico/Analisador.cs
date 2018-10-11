using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analisador_Lexico
{
    class Analisador
    {
        public void Analisar(char[] caracter)
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
                            
                            default:
                                if (Operadores.Op1(caracter[pos])){
                                    lexema += caracter[pos];
                                    estado = 7;
                                    pos++;
                                    
                                }
                                else {
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
                                if (Operadores.Op2(caracter[pos-1], caracter[pos]))
                                {
                                    lexema += caracter[pos];
                                    estado = 7;
                                    pos++;

                                }
                                else
                                {
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
                                //colocar na lista de lexemas
                                lexema = "";
                                estado = 0;
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
                                //colocar na lista de lexemas
                                lexema = "";
                                estado = 0;
                                pos++;
                                break;

                            default:
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
                        else
                        {
                            lexema = "";
                            estado = 0; 
                        }
                        break;

                    case 8:
                        if (Operadores.Op3(caracter[pos - 2], caracter[pos-1], caracter[pos]))
                        {
                            lexema += caracter[pos];
                            //adicionar na lista de lexemas
                            lexema = "";
                            estado = 0;
                            pos++;
                        }
                        else
                        {
                            lexema = "";
                            estado = 0;
                        }
                        break;


                    default:
                        estado = 0;
                        break;
            }
        }
    }
}
