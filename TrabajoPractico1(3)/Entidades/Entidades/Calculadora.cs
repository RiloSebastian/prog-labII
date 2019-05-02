using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Calculadora
    {
        public static double Operar(Numero Num1, Numero num2, string operador)
        {
            double Resultado=0;

            switch(char.Parse(Calculadora.ValidarOperador(operador)))
            {
                case '+':
                    Resultado = Num1 + num2;
                    break;
                case '-':
                    Resultado = Num1 - num2;
                    break;
                case '*':
                    Resultado = Num1 * num2;
                    break;
                case '/':
                    try
                    {
                        Resultado = Num1 / num2;
                    }
                    catch (DivideByZeroException)
                    {
                        Resultado = double.MinValue;
                    }
                    break;
                default:
                    break;
            }
            return Resultado;
        }

        private static string ValidarOperador(string Operador)
        {
            string Retorno = "+";
            char AuxiliarOperador;
            if(char.TryParse(Operador, out AuxiliarOperador))
            {
                switch (AuxiliarOperador)
                {
                    case '-':
                        Retorno = "-";
                        break;
                    case '*':
                        Retorno = "*";
                        break;
                    case '/':
                        Retorno = "/";
                        break;
                    default:
                        break;
                }
            }
            return Retorno;
        }
    }
}
