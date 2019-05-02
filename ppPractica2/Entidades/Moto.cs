using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindradas;
        private short ruedas;
        private int valorHora;

        private Moto() : base("---000")
        {
            valorHora = 30;
            ruedas = 2;
        }

        public Moto(string Patente, int Cilindrada) : base(Patente)
        {
            cilindradas = Cilindrada;
            valorHora = 30;
            ruedas = 2;
        }

        public Moto(string Patente, int Cilindrada, short Ruedas) : this(Patente, Cilindrada)
        {
            ruedas = Ruedas;
        }

        public Moto(string Patente, int Cilindrada, short Ruedas, int Valorhora) : this(Patente, Cilindrada, Ruedas)
        {
            valorHora = Valorhora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format("{0}", base.ImprimirTicket()));
            Retorno.AppendLine(string.Format("Cilindradas: {0}", cilindradas));
            Retorno.AppendLine(string.Format("Ruedas: {0}", ruedas));
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
