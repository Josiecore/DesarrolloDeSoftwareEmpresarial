using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referencia a mi librería
using LibCircunferencia;

namespace AppCircunferencia
{
    public partial class frmCircunferencia : Form
    {
        #region "Métodos propios"
            private void Limpiar()
            {
                this.txtX1.Text = string.Empty;
                this.txtX2.Text = string.Empty;
                this.txtY1.Text = string.Empty;
                this.txtY2.Text = string.Empty;
                this.txtRadio.Text = string.Empty;
                this.txtX1.Focus();
                this.gbpResultado.Visible = false;
            }
        #endregion
        public frmCircunferencia()
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

        private void frmCircunferencia_Load(object sender, EventArgs e)
        {
            this.txtX1.Focus();
            this.gbpResultado.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double dblX1, dblY1, dblX2, dblY2, dblRadio;

            try
            {
                dblX1 = Convert.ToDouble(txtX1.Text);
                dblY1 = Convert.ToDouble(txtY1.Text);
                dblX2 = Convert.ToDouble(txtX2.Text);
                dblY2 = Convert.ToDouble(txtY2.Text);
                dblRadio = Convert.ToDouble(txtRadio.Text);

                //Creando el objeto
                clsCircunferencia circunferencia = new clsCircunferencia();

                //Enviando los datos al objeto
                circunferencia.PuntoX1 = dblX1;
                circunferencia.PuntoX2 = dblX2;
                circunferencia.PuntoY1 = dblY1;
                circunferencia.PuntoY2 = dblY2;
                circunferencia.Radio = dblRadio;

                //Procesando
                if (!circunferencia.Calcular())
                {
                    MessageBox.Show(circunferencia.Error);
                    circunferencia = null;
                    return;
                }

                lblRespuesta.Text = circunferencia.Respuesta;
                this.gbpResultado.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
