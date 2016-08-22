using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//referencia
using LibFabricaDeZapatos;

namespace AppFabricaDeZapatos
{
    public partial class frmFabricaDeZapatos : Form
    {
        #region "Métodos personalizados"
        private void LimpiarCampos()
        {
            this.txtCantidadDePares.Text = string.Empty;
            this.txtCostoDeZapato.Text = string.Empty;
            this.txtSuperficie.Text = string.Empty;
            this.gbpResultados.Visible = false;
            this.txtCantidadDePares.Focus();
        }
        #endregion
        public frmFabricaDeZapatos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void frmFabricaDeZapatos_Load(object sender, EventArgs e)
        {
            this.gbpResultados.Visible = false;
           
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float fltEuro, fltCosto, fltSuperficie;
            int intCantidad;

            try
            {
                fltSuperficie = float.Parse(txtSuperficie.Text);
                fltCosto = float.Parse(txtCostoDeZapato.Text);
                fltEuro = float.Parse(txtValorEuro.Text);
                intCantidad = Convert.ToInt32(txtCantidadDePares.Text);

                //Creando el objeto
                clsFabricaDeZapatos objFabricaDeZapatos = new clsFabricaDeZapatos();

                //Enviando valores
                objFabricaDeZapatos.Caja = fltSuperficie;
                objFabricaDeZapatos.Cantidad = intCantidad;
                objFabricaDeZapatos.Costo = fltCosto;
                objFabricaDeZapatos.Euro = fltEuro;

                if (!objFabricaDeZapatos.Calcular())
                {
                    MessageBox.Show(objFabricaDeZapatos.Error);
                    objFabricaDeZapatos = null;
                    return;
                }

                this.lblTotalCajas.Text = objFabricaDeZapatos.ValorCajas.ToString();
                this.lblVentaDelZapato.Text = objFabricaDeZapatos.Costo.ToString();
                this.gbpResultados.Visible = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
