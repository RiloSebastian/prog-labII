using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        static int procentajeIva;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
            
        }

        static Venta()
        {
            procentajeIva = 21;
        }

        private void Vender(int cantidad)
        {
            producto.Stock = (producto.Stock - cantidad);
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double Retorno;

            Retorno = precioUnidad * cantidad;
            Retorno += (Retorno * procentajeIva) / 100;
            return Retorno;
        }

        public string ObtenerDescripcionBreve()
        {
            string Retorno;
            Retorno = string.Format("fecha: {0} -- descripcion: {1} -- precioFinal: ${2:#,0.00}", this.Fecha,
                this.producto.Descripcion, this.precioFinal);
            return Retorno;
        }
    }
}
