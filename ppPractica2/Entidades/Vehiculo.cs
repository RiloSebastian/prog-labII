using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;


        public string Patente
        {
            get
            {
                return patente;
            }
            set
            {
                if (value.Count<char>() == 6)
                {
                    patente = value;
                }
            }
        }

        public Vehiculo(string patente)
        {
            ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        public abstract string ConsultarDatos();

        public override string ToString()
        {
            return string.Format("patente {0}", this.Patente);
        }

        public virtual string ImprimirTicket()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();

            Retorno.AppendLine(string.Format("{0}", this.ToString()));
            Retorno.AppendLine(string.Format("hora de ingreso {0}", ingreso));

            return Retorno.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1.Patente == v2.Patente && v1.Equals(v2))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }


    }
}
