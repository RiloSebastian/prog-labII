using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic: Producto
    {
        private string autor;
        private TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic)
            :base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder Retorno;
            Retorno = new StringBuilder();
            Retorno.AppendLine(string.Format("{0}", base.ToString()));
            Retorno.AppendLine(string.Format(" autor: {0}", this.autor));
            Retorno.AppendLine(string.Format(" tipo de comic: {0}", this.tipoComic));

            return Retorno.ToString();
        }


    }
}
