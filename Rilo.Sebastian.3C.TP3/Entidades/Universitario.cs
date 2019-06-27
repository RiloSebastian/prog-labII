using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;


        public override bool Equals(object obj)
        {
            return (obj is Universitario);
        }

        protected virtual string MostratDatos()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();

            Retorno.AppendFormat("{0}",base.ToString());
            Retorno.AppendLine(string.Format("Legajo: {0}", this.legajo));

            return Retorno.ToString();
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if(pg1.GetType().Equals(pg2) && pg1.legajo == pg2.legajo || pg1.Dni == pg2.Dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        protected abstract string ParticiparEnClase();

        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, Enacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }


    }
}
