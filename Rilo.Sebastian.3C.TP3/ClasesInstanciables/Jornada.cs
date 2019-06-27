using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }
            set
            {
                alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return clase;
            }
            set
            {
                clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return instructor;
            }
            set
            {
                instructor = value;
            }
        }

        public static bool Guardar(Jornada jornada)
        {
            return new Texto().Guardar("jornada.txt",jornada.ToString());
        }

        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
        {
            Instructor = instructor;
            Clase = clase;
        }

        public static string leer()
        {
            string jornadaDatos;
            new Texto().Leer("jornada.txt",out jornadaDatos);
            return jornadaDatos;
        }

        public static bool operator ==(Jornada j, Alumno a)
        {
            if(!(a != j.Clase))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
                return j;
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            
        }
    

        public override string ToString()
        {
            StringBuilder Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format("clase {0}", Clase));
            Retorno.AppendFormat("{0}",Instructor.ToString());
            Retorno.AppendLine("Alumnos:");
            foreach (Alumno alumno in Alumnos)
            {
                Retorno.AppendFormat("{0}",alumno.ToString());
            }
            return Retorno.ToString();
        }
    }
}
