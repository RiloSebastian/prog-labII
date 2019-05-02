using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private int valorHora;

        private PickUp() : base("---000")
        {
            valorHora = 70;
        }

        public PickUp(string Patente, string Modelo) : base(Patente)
        {
            modelo = Modelo;
        }

        public PickUp(string Patente, string Modelo, int ValorHora) : this(Patente, Modelo)
        {
            valorHora = ValorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format("{0}", base.ImprimirTicket()));
            Retorno.AppendLine(string.Format("Modelo: {0}", modelo));
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
