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
    public partial class PrincipalFrm : Form
    {
        static TestDelegadosFrm delegadosFrm;
        static MostrarFrm mostrar;

        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarToolStripMenuItem.Enabled = true;
            delegadosFrm = new TestDelegadosFrm();
            delegadosFrm.MdiParent = this;
            delegadosFrm.Show();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar = new MostrarFrm();
            mostrar.MdiParent = this;
            mostrar.Show();
        }
    }
}
