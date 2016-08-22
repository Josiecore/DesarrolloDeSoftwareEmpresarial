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
using lblSueldoDiario;

namespace appSueldoEmpleado
{
    public partial class frmSueldoDiario : Form
    {
        #region "Métodos propios"
        private void Limpiar()
        {
            this.txtHorasDiurnas.Text = string.Empty;
            this.txtHorasNocturnas.Text = string.Empty;
            this.txtHoraNormal.Text = string.Empty;
            this.gbpSalario.Visible = false;
            this.cmbDias.Focus();
            this.cmbDias.SelectedIndex = 0;
        }

        private void LlenarCombo()
        {
            cmbDias.Items.Add("Seleccione un día");
            cmbDias.Items.Add("Domingo");
            cmbDias.Items.Add("Festivo");
            cmbDias.Items.Add("Lunes");
            cmbDias.Items.Add("Martes");
            cmbDias.Items.Add("Miércoles");
            cmbDias.Items.Add("Jueves");
            cmbDias.Items.Add("Viernes");
            cmbDias.Items.Add("Sábado");
            cmbDias.SelectedIndex = 0;
        }
        #endregion
        public frmSueldoDiario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSueldoDiario_Load(object sender, EventArgs e)
        {
            this.gbpSalario.Visible = false;
            this.LlenarCombo();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int intDia;
            float fltDiurnas, fltNocturnas, fltValorHora;

            try
            {
                //Capturando los datos
                intDia = cmbDias.SelectedIndex;
                fltDiurnas = float.Parse(txtHorasDiurnas.Text);
                fltNocturnas = float.Parse(txtHorasNocturnas.Text);
                fltValorHora = float.Parse(txtHoraNormal.Text);

                //Creando el objeto
                clsSueldoDiario objSueldo = new clsSueldoDiario();

                //Enviando los datos al objeto
                objSueldo.Dia = intDia;
                objSueldo.HorasDiurnas = fltDiurnas;
                objSueldo.HorasNocturnas = fltNocturnas;
                objSueldo.HoraNormal = fltValorHora;

                //Calcular
                if (!objSueldo.Calcular())
                {
                    MessageBox.Show(objSueldo.Error);
                    objSueldo = null;
                    return;
                }

                lblSueldo.Text = objSueldo.Salario.ToString();
                this.gbpSalario.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
