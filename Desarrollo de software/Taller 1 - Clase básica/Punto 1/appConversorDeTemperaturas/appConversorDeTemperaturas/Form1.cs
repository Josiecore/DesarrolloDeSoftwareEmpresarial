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

using LibConversorDeTemperatura;

namespace appConversorDeTemperaturas
{
    public partial class frmConversorDeTemperaturas : Form
    {
        #region "Variables globales"
            float fltTemperatura;
            int intEscalaDeEntrada;
            int intEscalaDeSalida;
        #endregion

        #region "Métodos propios del formulario"
        private void llenarComboDeEntrada() //Llena el combo de los tipos de entrada
        {
            this.cmbGradosDeEntrada.Items.Add("Seleccione");
            this.cmbGradosDeEntrada.Items.Add("Celsius");
            this.cmbGradosDeEntrada.Items.Add("Fahrenheit");
            this.cmbGradosDeEntrada.Items.Add("Kelvin");
            this.cmbGradosDeEntrada.Items.Add("Rankine");
            this.cmbGradosDeEntrada.SelectedIndex = 0;

        }

        private void llenarComboDeSalida()
        {
            this.cmbGradosDeSalida.Items.Add("Seleccione");
            this.cmbGradosDeSalida.Items.Add("Celsius");
            this.cmbGradosDeSalida.Items.Add("Fahrenheit");
            this.cmbGradosDeSalida.Items.Add("Kelvin");
            this.cmbGradosDeSalida.Items.Add("Rankie");
            this.cmbGradosDeSalida.SelectedIndex = 0;
        }

        private void Limpiar()
        {
            this.cmbGradosDeEntrada.SelectedIndex = 0;
            this.txtCantidadDeGradosDeEntrada.Text = string.Empty;
            this.cmbGradosDeSalida.SelectedIndex = 0;
            this.gbpResultado.Visible = false;
            this.cmbGradosDeEntrada.Focus();
        }
        #endregion

        public frmConversorDeTemperaturas()
        {
            InitializeComponent();
        }

        #region "Eventos sobre los botones"

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConversorDeTemperaturas_Load(object sender, EventArgs e)
        {
            this.llenarComboDeEntrada();
            this.llenarComboDeSalida();
            this.cmbGradosDeEntrada.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            
                try
                {
                    fltTemperatura = float.Parse(txtCantidadDeGradosDeEntrada.Text);
                    intEscalaDeEntrada = cmbGradosDeEntrada.SelectedIndex;
                    intEscalaDeSalida = cmbGradosDeSalida.SelectedIndex;

                //Creando el objeto!
                ClsConversorDeTemperatura objConversor = new ClsConversorDeTemperatura();

                //Enviando información al objeto
                objConversor.Temperatura = this.fltTemperatura;
                objConversor.EscalaDeEntrada = this.cmbGradosDeEntrada.SelectedIndex;
                objConversor.EscalaDeSalida = this.cmbGradosDeSalida.SelectedIndex;

                    if (!objConversor.Convertir())
                    {
                        MessageBox.Show("Ocurrió un error :( " + objConversor.Error);
                        objConversor = null;
                        return;
                    }

                    this.gbpResultado.Visible = true;
                    this.lblResultado.Text = objConversor.Temperatura.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocurrió un error: " + ex.Message + " :C");
                }
        }

        #endregion
    }
}
