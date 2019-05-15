using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura: Producto
    {
        private double altura;

        public Figura(int stock, double precio, double altura):base("Figura "+altura+"cm",stock,precio)
        {
            this.altura = altura;
        }

        public Figura(string descripcion, int stock, double precio, double altura):this(stock, precio,altura)
        {
        }

        public override string ToString()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format("{0}", base.ToString()));
            Retorno.AppendLine(string.Format(" altura: {0} cm", this.altura));

            return Retorno.ToString();
        }

    }
}
