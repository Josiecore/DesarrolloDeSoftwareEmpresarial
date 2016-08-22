using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Referencia a mi DLL
using LibAumentoDeSueldo;


namespace WindowsFormsApplication1
{
    public partial class frmAumentoEmpleado : Form
    {
        #region "Varibales globales"
            float fltSueldo;
            int intExperiencia;
        #endregion

        #region "Métodos personalizados"
        private void Limpiar()
            {
                this.txtSueldo.Text = String.Empty;
                this.txtTiempoTrabajado.Text = String.Empty;
                this.gbpAumento.Visible = false;
                this.txtSueldo.Focus();

            }
        #endregion

        public frmAumentoEmpleado()
        {
            InitializeComponent();
        }

        private void frmAumentoEmpleado_Load(object sender, EventArgs e)
        {
            this.gbpAumento.Visible = false;
            this.txtSueldo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //Capturando los datos de la GUI
                fltSueldo = float.Parse(txtSueldo.Text);
                intExperiencia = Convert.ToInt16(txtTiempoTrabajado.Text);

                //Creando el objeto de la clase
                clsAumentoDeSueldo objAumentoDeSueldo = new clsAumentoDeSueldo();

                //Enviando los valores al objeto
                objAumentoDeSueldo.Sueldo = fltSueldo;
                objAumentoDeSueldo.Experiencia = intExperiencia;

                if (!objAumentoDeSueldo.CalcularAumento())
                {
                    MessageBox.Show("Ocurrió un error: " + objAumentoDeSueldo.Error);
                    objAumentoDeSueldo = null;
                    return;
                }

                //Retornando los resultados a la GUI
                lblPorcentajeDelAumento.Text = objAumentoDeSueldo.PorcentajeAumento.ToString() + " %";
                lblValorAumento.Text = objAumentoDeSueldo.MontoDelAumento.ToString();
                this.gbpAumento.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
