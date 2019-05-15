using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
            }
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            Stock = stock;
            this.precio = precio;
            this.codigo = Guid.NewGuid();
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }
        /// <summary>
        /// genera un texto a partir de un stringBuilder con informacion del producto
        /// </summary>
        /// <returns>el texto ya generado </returns>
        public override string ToString()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format(" descripcion: {0}", Descripcion));
            Retorno.AppendLine(string.Format(" codigo: {0}", this.codigo));
            Retorno.AppendLine(string.Format(" precio: ${0}", Precio));
            Retorno.AppendLine(string.Format(" stock: {0} unidades", Stock));

            return Retorno.ToString();
        }


    }
}
