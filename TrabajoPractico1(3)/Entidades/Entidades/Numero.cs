using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double Num;

        public string SetNumero
        {
            set => Num =ValidarNumero(value);
        }
        
        public Numero(double numero)
        {
            this.Num = numero;
        }
        public Numero() : this(0)
        {
        }
        public Numero(string StrNumero)
        {
            this.SetNumero = StrNumero;
        }

        public static double operator +(Numero n1, Numero n2)
        {
            double Retorno=0;
            Retorno = n1.Num + n2.Num;
            return Retorno;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double Retorno = -1;
            Retorno = n1.Num - n2.Num;
            return Retorno;
        }

        public static double operator *(Numero n1, Numero n2)
        {
            double Retorno = -1;
            Retorno = n1.Num * n2.Num;
            return Retorno;
        }

        public static double operator /(Numero n1, Numero n2)
        {
            double Retorno = -1;
            Retorno = n1.Num / n2.Num;
            return Retorno;
        }

        private static double ValidarNumero(string StrNumero)
        {
            double Retorno = -1;
            if(double.TryParse(StrNumero, out Retorno))
            {
                return Retorno;
            }
            return Retorno;
        }

        public static string BinarioDecimal(string Binario)
        {
            string Retorno;
            char[] Numero = Binario.ToCharArray();
            Array.Reverse(Numero);
            int NumeroConvertido = 0;
            double Auxiliar;

            if (double.TryParse(Binario,out Auxiliar))
            {
                for (int i = 0; i < Numero.Length; i++)
                { 
                    if(Numero[i] == '1')
                    {
                        NumeroConvertido += (int)Math.Pow(2, i);
                    }
                }
                Retorno = NumeroConvertido.ToString();
                return Retorno;
            }
            return "Valor Invalido";
        }
        
        public static string DecimalBinario(double Decimal)
        {
            string Retorno="Valor Invalido";

            if (!double.IsNaN(Decimal))
            {
                int numero = Convert.ToInt32(Decimal);
                if (numero > 0)
                {
                    String cadena = "";
                    while (numero > 0)
                    {
                        if (numero % 2 == 0)
                        {
                            cadena = "0" + cadena;
                        }
                        else
                        {
                            cadena = "1" + cadena;
                        }
                        numero = (int)(numero / 2);
                    }
                    Retorno = string.Copy(cadena);
                }
                else
                {
                    if (numero == 0)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese solo numeros positivos");
                    }

                }
            }
            return Retorno;
        }

        public static string DecimalBinario(string Decimal)
        {
            double Auxiliar;
            if (double.TryParse(Decimal, out Auxiliar))
            {
                return Numero.DecimalBinario(Auxiliar);
            }
            return "Valor Invalido";
        }


    }
}
