using ComiqueriaLogic;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class ModificarProductoForm : Form
    {
        private Producto productoSeleccionado;

        /// <summary>
        /// Constructor. 
        /// </summary>
        /// <param name="productoSeleccionado">Producto seleccionado por el usuario en la lista del principalForm.</param>
        public ModificarProductoForm(Producto productoSeleccionado)
        {
            InitializeComponent();
            this.productoSeleccionado = productoSeleccionado;
        }

        /// <summary>
        /// Manejador del evento OnLoad del formulario. 
        /// Inicializará el lblDescripción y el lblPrecioActual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = this.productoSeleccionado.Descripcion;
            this.txtPrecioActual.Text = String.Format("{0:0.00}", this.productoSeleccionado.Precio);
        }

        /// <summary>
        /// Manejador del evento OnClick del btnModificar. 
        /// Actualiza el precio del producto seleccionado en la base de datos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnModificarClick(object sender, EventArgs e)
        {
            double nuevoPrecio;
            if (Double.TryParse(this.txtNuevoPrecio.Text, out nuevoPrecio))
            {
                DialogResult result = MessageBox.Show("¿Seguro desea modificar el producto?", "Modificar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Punto 4B - Actualizar el precio del producto en la tabla de productos. 
                    SqlCommand command = new SqlCommand();
                    SqlConnection connection = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog =Comiqueria; Integrated Security = True");
                    try
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.Connection = connection;
                        command.CommandText = string.Format("UPDATE Comiqueria SET Precio ='{0}' WHERE codigo = {1}", nuevoPrecio, productoSeleccionado.Codigo);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error de conexion de servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    this.Close();
                }
            }
            else
            {
                this.lblError.Text = "Error. Debe ingresar un precio válido.";
            }   
        }

        /// <summary>
        /// Manejador del evento click del botón cancelar.
        /// Cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Manejador del evento OnChange del txtNuevoPrecio. 
        /// Limpiará el lblError.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNuevoPrecio_TextChanged(object sender, EventArgs e)
        {
            this.lblError.Text = String.Empty;
        }
    }
}
