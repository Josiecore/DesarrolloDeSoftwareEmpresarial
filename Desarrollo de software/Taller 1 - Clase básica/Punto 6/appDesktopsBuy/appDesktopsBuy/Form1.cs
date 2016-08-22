using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referenciando la librería
using LibVentas;

namespace appDesktopsBuy
{
    public partial class frmDesktops : Form
    {
        #region "Métodos propios"
        private void Limpiar()
        {
            this.txtCantidad.Text = string.Empty;
            this.txtPrecioUnitario.Text = string.Empty;
            this.gbpResultado.Visible = false;
            this.txtCantidad.Focus();
        }
        #endregion
        public frmDesktops()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDesktops_Load(object sender, EventArgs e)
        {
            this.gbpResultado.Visible = false;
            this.txtCantidad.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float fltPrecioUnitario;
            int intCantidad;

            try
            {
                //Capturando los valores de la GUI
                fltPrecioUnitario = float.Parse(txtPrecioUnitario.Text);
                intCantidad = Convert.ToInt32(txtCantidad.Text);

                //Creando el objeto
                clsTienda objTienda = new clsTienda();

                //Enviando valores al objeto
                objTienda.Cantidad = intCantidad;
                objTienda.PrecioUnitario = fltPrecioUnitario;

                if (!objTienda.Calcular())
                {
                    MessageBox.Show(objTienda.Error);
                    objTienda = null;
                    return;
                }

                this.lblResultado.Text = objTienda.PrecioTotal.ToString();
                this.gbpResultado.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
