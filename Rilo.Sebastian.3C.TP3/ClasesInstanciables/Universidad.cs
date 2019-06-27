using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excepciones;
using System.Threading.Tasks;
using Archivos;

namespace ClasesInstanciables
{
    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

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

        public List<Profesor> Instructores
        {
            get
            {
                return profesores;
            }
            set
            {
                profesores = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return jornada;
            }
            set
            {
                jornada = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < Jornadas.Count)
                {
                    return Jornadas[i];
                }
                return null;
            }
            set
            {
                if (i >= 0 && i < Jornadas.Count)
                {
                    Jornadas[i] = value;
                }
                else if (i == Jornadas.Count)
                {
                    Jornadas.Add(value);
                }
            }
        }

        public static bool Guardar(Universidad uni)
        {
            return new Xml<Universidad>().Guardar("Universidad.xml", uni);
        }

        public static Universidad Leer()
        {
            Universidad uni;
            new Xml<Universidad>().Leer("Universidad.xml", out uni);
            return uni;
        }

        private string MostrarDatos(Universidad uni)
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            foreach(Jornada j in Jornadas)
            {
                Retorno.AppendFormat("0",j.ToString());
            }
            return Retorno.ToString();
        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                    return true;
            }
            return false;
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor p in g.Instructores)
            {
                if (p == i)
                    return true;
            }
            return false;
        }

        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor p in u.Instructores)
            {
                if (p == clase)
                    return p;
            }
            throw new SinProfesorException();
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j;
            Profesor auxiliar;
            auxiliar = new Profesor();
            List<Alumno> alumnosAuxiliar;
            alumnosAuxiliar = new List<Alumno>();

            foreach(Profesor p in g.profesores)
            {
                if(p==clase)
                {
                    auxiliar = p;
                    break;
                }
            }
            foreach(Alumno a in g.alumnos)
            {
                if(a==clase)
                {
                    alumnosAuxiliar.Add(a);
                }
            }
            j = new Jornada(clase, auxiliar);
            j.Alumnos = alumnosAuxiliar;
            g.Jornadas.Add(j);
            return g;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
                return u;
            }
            throw new AlumnoRepetidoException();

        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Instructores.Add(i);
            }
            return u;

        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g==a);
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g==i);
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor p in u.Instructores)
            {
                if (p != clase)
                    return p;
            }
            return null;
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public Universidad()
        {
            Alumnos = new List<Alumno>();
            Instructores = new List<Profesor>();
            Jornadas = new List<Jornada>();
        }
    }
}
