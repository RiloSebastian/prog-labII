using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid i]
        {
            get
            {
                foreach(Producto p in this.productos)
                {
                    if(i == (Guid)p)
                    {
                        return p;
                    }
                    
                }
                return null;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach(Producto productoAuxiliar in comiqueria.productos)
            {
                if(string.Compare(producto.Descripcion,productoAuxiliar.Descripcion)==0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {

            if(comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }
            return comiqueria;
        }

        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta v;
            v = new Venta(producto, cantidad);
            ventas.Add(v);
        }

        public string ListarVentas()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            
            foreach(Venta v in this.ventas)
            {
                Retorno.AppendLine(string.Format("{0}", v.ObtenerDescripcionBreve()));
            }
            return Retorno.ToString();
        }

        private int OrdenarElementos(Venta v1, Venta v2)
        {
            int Retorno=0;
            if(v1.Fecha > v2.Fecha)
            {
                return 1;
            }
            else if(v1.Fecha < v2.Fecha)
            {
                return -1;
            }
            return Retorno;
        }

        public Dictionary<Guid,string> ListarProductos()
        {
            Dictionary<Guid, string> diccionario;
            diccionario = new Dictionary<Guid, string>();
            foreach(Producto p in productos)
            {
                diccionario.Add((Guid)p, p.Descripcion);
            }
            return diccionario;
        }
    }
}
