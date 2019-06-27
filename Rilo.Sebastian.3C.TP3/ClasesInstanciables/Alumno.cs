using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        public enum EEstadoDeCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        private Universidad.EClases claseQueToma;
        private EEstadoDeCuenta estadoDeCuenta;

        public Alumno()
        { }

        public Alumno(int id, string nombre, string apellido, string dni, Enacionalidad nacionalidad, Universidad.EClases clasesQueToma)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = clasesQueToma;
        }

        public Alumno(int id, string nombre, string apellido, string dni, Enacionalidad nacionalidad, Universidad.EClases clasesQueToma, 
            EEstadoDeCuenta estadoDeCuenta):this(id,nombre,apellido,dni,nacionalidad,clasesQueToma)
        {
            this.estadoDeCuenta = estadoDeCuenta;
        }

        protected override string MostratDatos()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();

            Retorno.AppendFormat("{0}", base.MostratDatos());
            Retorno.AppendFormat("{0}", ParticiparEnClase());
            Retorno.AppendLine(string.Format("estado de cuenta: {0}", this.estadoDeCuenta));

            return Retorno.ToString();
        }

        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
           if(a.claseQueToma==clase && a.estadoDeCuenta != EEstadoDeCuenta.Deudor)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if(a.claseQueToma != clase)
            {
                return true;
            }
            return false;
        }

        protected override string ParticiparEnClase()
        {
            return string.Format("toma clase de: {0}", this.claseQueToma);
        }

        public override string ToString()
        {
            return MostratDatos();
        }
    }
}
