using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum Enacionalidad
        {
            Argentino,
            Extranjero
        }

        private string nombre;
        private string apellido;
        private Enacionalidad nacionalidad;
        private int dni;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        public Enacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                dni = ValidarDni(Nacionalidad, value);
            }
        }

        public string StringToDni
        {
            set
            {
                dni = ValidarDni(Nacionalidad, value);
            }
        }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, Enacionalidad nacionalidad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni ,Enacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        { 
            Dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, Enacionalidad nacionalidad) : this(nombre,apellido,nacionalidad)
        {
            StringToDni = dni;
        }

        public override string ToString()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();

            Retorno.AppendLine(string.Format("Nombre: {0}", Nombre));
            Retorno.AppendLine(string.Format("Apellido: {0}", Apellido));
            Retorno.AppendLine(string.Format("Nacionalidad: {0}", Nacionalidad));
            Retorno.AppendLine(string.Format("Dni: {0}", Dni));

            return Retorno.ToString();
        }

        private int ValidarDni(Enacionalidad nacionalidad, int dato)
        {
            if ((nacionalidad == Enacionalidad.Argentino && dato >= 1 && dato <= 89999999) ||
               (nacionalidad == Enacionalidad.Extranjero && dato >= 90000000 && dato <= 99999999))
            {
                return dato;
            }
            else
            {
                if (nacionalidad == Enacionalidad.Argentino && dato < 1 && dato > 89999999)
                {
                    throw new NacionalidadInvalidaException("los dni de nacionalidad argentina deben estar entre 1 y 89999999");
                }
                else if (nacionalidad == Enacionalidad.Extranjero && dato < 90000000 && dato > 99999999)
                {
                    throw new NacionalidadInvalidaException("los dni de nacionalidad extranjera deben estar entre 90000000 y 99999999");
                }
                else
                {
                    throw new NacionalidadInvalidaException();
                }
            }
        }

        private int ValidarDni(Enacionalidad nacionalidad, string dato)
        {
            int auxiliar=0;
            int retorno = 0;
            if (dato.Length == 8 && int.TryParse(dato, out auxiliar))
            {
               return ValidarDni(nacionalidad, auxiliar);
            }
            else
            {
                if(dato.Length > 8)
                {
                    throw new DniInvalidoException("el dni no puede ser mayor a 8 digitos");
                }
                else if(!int.TryParse(dato, out auxiliar))
                {
                    throw new DniInvalidoException("el dni debe ser un entero");
                }
                else
                {
                    throw new DniInvalidoException();
                }
            }
        }

        private string ValidarNombreApellido(string dato)
        {
            if (Regex.IsMatch(dato, @"^[a-zA-Záéíóú]+$"))
            {
                return dato;
            }
            else
            {
                throw new Exception("el nombre no tiene caracteres validos");
            }
        }

    }
}
