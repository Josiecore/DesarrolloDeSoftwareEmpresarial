using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referencia
using LibEcuacionCuadratica;

namespace appEcuacionCuadratica
{
    public partial class frmEcuacionCuadratica : Form
    {
        #region "Métodos personalizados"
        private void Limpiar()
        {
            this.txtA.Text = string.Empty;
            this.txtB.Text = string.Empty;
            this.txtC.Text = string.Empty;
            this.gbpSoluciones.Visible = false;
            this.txtA.Focus();
        }
        #endregion

        #region "Variables globales"
            float fltA, fltB, fltC;
            
        #endregion
        public frmEcuacionCuadratica()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEcuacionCuadratica_Load(object sender, EventArgs e)
        {
            this.txtA.Focus();
            this.gbpSoluciones.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturando los valores de la GUI

                this.fltA = float.Parse(txtA.Text);
                this.fltB = float.Parse(txtB.Text);
                this.fltC = float.Parse(txtC.Text);

                //Creando el objeto
                clsEcuacionCuadratica objEcuacionCuadratica = new clsEcuacionCuadratica();

                //Enviando los valores al objeto
                objEcuacionCuadratica.TerminoA = this.fltA;
                objEcuacionCuadratica.TerminoB = this.fltB;
                objEcuacionCuadratica.TerminoC = this.fltC;

                if (!objEcuacionCuadratica.Calcular())
                {
                    MessageBox.Show(objEcuacionCuadratica.Error);
                    objEcuacionCuadratica = null;
                    return;
                }

                this.lblSolucion1.Text = objEcuacionCuadratica.Resultado1;
                this.lblSolucion2.Text = objEcuacionCuadratica.Resultado2;
                this.gbpSoluciones.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
