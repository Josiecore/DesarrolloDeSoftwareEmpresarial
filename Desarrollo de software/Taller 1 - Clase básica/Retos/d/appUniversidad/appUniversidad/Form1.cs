using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Agregando la referencia DLL
using LibUniversidad;

namespace appUniversidad
{
    public partial class frmCreditos : Form
    {
        #region "Métodos propios"
        private void Limpiar()
        {
            this.txtPromedio.Text = string.Empty;
            this.cmbTipo.SelectedIndex = 0;
            this.gbpResultado.Visible = false;
        }

        private void LlenarCombo()
        {
            this.cmbTipo.Items.Add("Seleccione");
            this.cmbTipo.Items.Add("Pregrado");
            this.cmbTipo.Items.Add("Posgrado");
            this.cmbTipo.SelectedIndex = 0;
            this.cmbTipo.Focus();
        }
        #endregion
        public frmCreditos()
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

        private void frmCreditos_Load(object sender, EventArgs e)
        {
            this.LlenarCombo();
            this.cmbTipo.Focus();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            float fltPromedio;
            int intTipo;

            //Capturando datos de la GUI
            fltPromedio = float.Parse(txtPromedio.Text);
            intTipo = cmbTipo.SelectedIndex;

            //Creando el objeto
            clsMatricula objMatricula = new clsMatricula();

            //Enviando los datos al objeto
            objMatricula.Promedio = fltPromedio;
            objMatricula.Tipo = intTipo;

            //Procesando 
            if (!objMatricula.Calcular())
            {
                MessageBox.Show(objMatricula.Error);
                objMatricula = null;
                return;
            }

            lblCreditos.Text = objMatricula.Creditos.ToString();
            lblTotal.Text = objMatricula.Total.ToString();
            this.gbpResultado.Visible = true;

        }
    }
}
