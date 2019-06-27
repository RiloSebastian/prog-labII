using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        static Random random;

        private void _ramdomClases()
        {
            
            for(int i=0;i<2;i++)
            {
                clasesDelDia.Enqueue((Universidad.EClases)random.Next(0, 3));
            }
        }

        protected override string MostratDatos()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();

            Retorno.AppendFormat("{0}", base.MostratDatos());
            Retorno.AppendFormat("{0}",ParticiparEnClase());
           
            return Retorno.ToString();
        }

        public static bool operator ==(Profesor p, Universidad.EClases clase)
        {
            if(p.clasesDelDia.Contains(clase))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Profesor p, Universidad.EClases clase)
        {
            return !(p == clase);
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();

            Retorno.AppendLine("Clases del Dia");
            foreach (Universidad.EClases clases in clasesDelDia)
            {
                Retorno.AppendLine(string.Format("{0}", clases));
            }
            return Retorno.ToString();
        }

        public Profesor()
        {
            clasesDelDia = new Queue<Universidad.EClases>();
        }

        static Profesor()
        {
           random  = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, Enacionalidad nacionalidad)
            :base(id,nombre,apellido,dni,nacionalidad)
        {
            clasesDelDia = new Queue<Universidad.EClases>();
            _ramdomClases(); 
        }

        public override string ToString()
        {
            return MostratDatos();
        }
    }
}
