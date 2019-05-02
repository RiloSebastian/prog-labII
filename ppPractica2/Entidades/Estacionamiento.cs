using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;


        private Estacionamiento()
        {
            vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string Nombre, int EspacioDisponible)
        {
            nombre = Nombre;
            espacioDisponible = EspacioDisponible;
        }

        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format("Nombre: {0}", e.nombre));
            Retorno.AppendLine(string.Format("Espacio Disponible: {0}", e.espacioDisponible));
            Retorno.AppendLine("vehiculos:");
            foreach (Vehiculo v in e.vehiculos)
            {
                Retorno.AppendLine(string.Format("{0}", v.ConsultarDatos()));
                Retorno.AppendLine("");

            }
            return Retorno.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            if (e.vehiculos.Contains(v))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (!(e == v) && v.Patente != null && e.espacioDisponible > e.vehiculos.Count)
            {
                e.vehiculos.Add(v);
            }
            return e;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            if (!(e == v))
            {
                e.vehiculos.Remove(v);
                return v.ImprimirTicket();
            }
            return "el vehiculo no forma parte del estacionamiento.";
        }
    }
}

