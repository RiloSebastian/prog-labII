using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace VentasForm
{
  public partial class formVentas : Form
  {
        private Producto producto;
        private Comiqueria comiqueria;

    public formVentas(Comiqueria comiqueriaLista, Producto productoAVender)
    {
      InitializeComponent();
            comiqueria = comiqueriaLista;
            producto = productoAVender;
            lblDescripcionBreve.Text = producto.Descripcion;
      
    }

  }
}
