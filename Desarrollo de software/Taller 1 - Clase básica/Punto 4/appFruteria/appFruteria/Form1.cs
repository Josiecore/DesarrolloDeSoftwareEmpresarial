using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referencia de mi librería
using LibFruteria;

namespace appFruteria
{
    public partial class frmFruteria : Form
    {
        #region "Métodos propios"
            private void Limpiar()
            {
                this.txtCantidad.Text = string.Empty;
                this.txtIVA.Text = string.Empty;
                this.txtValorUnitario.Text = string.Empty;
                this.gbpTotal.Visible = false;
                this.txtCantidad.Focus();
            }
        #endregion

        public frmFruteria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void frmFruteria_Load(object sender, EventArgs e)
        {
            this.gbpTotal.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int intCantidad;
            float fltValorUnitario, fltIVA;

            try
            {
                //Capturando datos los datos de GUI

                intCantidad = Convert.ToInt32(txtCantidad.Text);
                fltValorUnitario = float.Parse(txtValorUnitario.Text);
                fltIVA = float.Parse(txtIVA.Text);

                //Creando el objeto
                clsFruteria objCompra = new clsFruteria();

                //Enviando los valores al objeto

                objCompra.Cantidad = intCantidad;
                objCompra.ValorUnitario = fltValorUnitario;
                objCompra.IVA = fltIVA;

                if (!objCompra.Calcular())
                {
                    MessageBox.Show("Error: " + objCompra.Error);
                    objCompra = null;
                    return;

                }

                this.lblTotalAPagar.Text = objCompra.ValorAPagar.ToString();
                this.gbpTotal.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
