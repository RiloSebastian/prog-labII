using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public delegate void DelegadoActualizar(string dato);
    public partial class MostrarFrm : Form
    {
        public MostrarFrm()
        {
            InitializeComponent();
            TestDelegadosFrm.nombreActualizado += ActualizarNombre;
        }

        public void ActualizarNombre(string nombre)
        {
            lblEtiqueta.Text = nombre;
        }
    }
}
