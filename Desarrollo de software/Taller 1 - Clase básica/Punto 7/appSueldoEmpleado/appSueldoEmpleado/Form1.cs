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
using LibSueldoDeEmpleado;

namespace appSueldoEmpleado
{
    public partial class frmSueldo : Form
    {
        #region "Métodos propios"
        private void LimpiarCampos()
        {
            this.txtNombre.Text = string.Empty;
            this.txtPrimerApellido.Text = string.Empty;
            this.txtSegundoApellido.Text = string.Empty;
            this.txtExperiencia.Text = string.Empty;
            this.txtValorDelEuro.Text = string.Empty;
            this.txtSueldoBase.Text = string.Empty;
            this.gbpResultados.Visible = false;
            this.txtNombre.Focus();
        }
        #endregion
        public frmSueldo()
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

        private void frmSueldo_Load(object sender, EventArgs e)
        {
            this.txtNombre.Focus();
            this.gbpResultados.Visible = false;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string strNombre, strPrimerApellido, strSegundoApellido;
            float fltSueldoBase, fltValorEuro;
            int intExperiencia;

            try
            {
                strNombre = txtNombre.Text;
                strPrimerApellido = txtPrimerApellido.Text;
                strSegundoApellido = txtSegundoApellido.Text;
                fltSueldoBase = float.Parse(txtSueldoBase.Text);
                fltValorEuro = float.Parse(txtValorDelEuro.Text);
                intExperiencia = Convert.ToInt16(txtExperiencia.Text);

                //Creando el objeto
                clsSueldoDeEmpleado objSueldo = new clsSueldoDeEmpleado();

                //Enviando datos al objeto
                objSueldo.Nombre = strNombre;
                objSueldo.PrimerApellido = strPrimerApellido;
                objSueldo.SegundoApellido = strSegundoApellido;
                objSueldo.Experiencia = intExperiencia;
                objSueldo.Euro = fltValorEuro;
                objSueldo.SueldoBase = fltSueldoBase;

                if (!objSueldo.CalcularSalario())
                {
                    MessageBox.Show("Error: " + objSueldo.Error);
                    objSueldo = null;
                    return;
                }

                lblEmpleado.Text = objSueldo.Nombre + " " + objSueldo.PrimerApellido + " " + objSueldo.SegundoApellido;
                lblMesNormalBruto.Text = objSueldo.SueldoBrutoNormal.ToString();
                lblNormalNeto.Text = objSueldo.SueldoNetoNormal.ToString();
                lblPagaExtraBruta.Text = objSueldo.SueldoBrutoExtra.ToString();
                lblPagaExtra.Text = objSueldo.SueldoNetoExtra.ToString();
                lblTotalBruto.Text = objSueldo.SueldoBrutoTotal.ToString();
                lblTotalExtra.Text = objSueldo.SueldoNetoTotal.ToString();

                this.gbpResultados.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                
            }
        }
    }
}
