using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private int valorHora;

        private Automovil() : base("---000")
        {
            valorHora = 50;
        }

        public Automovil(string Patente, ConsoleColor Color) : base(Patente)
        {
            color = Color;
        }

        public Automovil(string Patente, ConsoleColor Color, int ValorHora) : this(Patente, Color)
        {
            valorHora = ValorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format("{0}", base.ImprimirTicket()));
            Retorno.AppendLine(string.Format("Color: {0}", color));
            Retorno.AppendLine(string.Format("Valor por Hora: {0}", valorHora));

            return Retorno.ToString();
        }

        public override string ImprimirTicket()
        {
            StringBuilder Retorno;
            int horasEstacionadas = int.Parse(DateTime.Now.Subtract(ingreso).ToString());
            int Resultado = horasEstacionadas * valorHora;
            Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format("{0}", base.ImprimirTicket()));
            Retorno.AppendLine(string.Format("Costo de Estadia: ${0}", Resultado));
            return Retorno.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj.Equals(this))
            {
                return true;
            }
            return false;
        }
    }
}
