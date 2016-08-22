using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Añadiendo la referencia

using LibNeumatico;
namespace appMasaNeumatico
{
    public partial class frmMasaDeAire : Form
    {
        #region "Métodos propios"
            private void Limpiar()
            {
                this.txtTemperatura.Text = string.Empty;
                this.txtPresion.Text = string.Empty;
                this.txtVolumen.Text = string.Empty;
                this.gbpMasaDeAire.Visible = false;
                this.txtTemperatura.Focus();
            }
        #endregion
        public frmMasaDeAire()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void frmMasaDeAire_Load(object sender, EventArgs e)
        {
            this.gbpMasaDeAire.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float fltTemperatura, fltPresion, fltVolumen;

            try
            {
                //Capturando los datos de la GUI
                fltPresion = float.Parse(txtPresion.Text);
                fltTemperatura = float.Parse(txtTemperatura.Text);
                fltVolumen = float.Parse(txtVolumen.Text);

                //Creando el objeto
                clsMasaDeAire objCalcularMasa = new clsMasaDeAire();

                //Enviando los valores al objeto
                objCalcularMasa.Temperatura = fltTemperatura;
                objCalcularMasa.Presion = fltPresion;
                objCalcularMasa.Volumen = fltVolumen;

                //Procesando!
                if (!objCalcularMasa.Calcular()) 
                {
                    MessageBox.Show("Error: " + objCalcularMasa.Error);
                    objCalcularMasa = null;
                    return;
                }

                    lblMasa.Text = objCalcularMasa.Masa.ToString();
                    this.gbpMasaDeAire.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
