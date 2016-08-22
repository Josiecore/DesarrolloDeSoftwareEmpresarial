using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNeumatico
{
    public class clsMasaDeAire
    {
        #region "Atributos"

            private float fltTemperatura, fltPresion, fltVolumen, fltMasa;
            private string strError;

        #endregion

        #region "Propiedades"

            public float Temperatura { set { fltTemperatura = value; }}
            public float Presion { set { fltPresion = value; } } 
            public float Volumen { set { fltVolumen = value; } }
            public float Masa { get { return fltMasa; } }
            public string Error { get { return strError; } }

        #endregion

        #region "Métodos privados"

            private bool Validar()
            {
                if (fltPresion < 0)
                {
                    strError = "Presión no válida.";
                    return false;
                }

                if (fltVolumen <= 0)
                {
                    strError = "Volumen no válido";
                    return false;
                }

                return true;        
            }

        private void Convertir()
        {
            fltTemperatura = ((9.0F / 5.0F) * (fltTemperatura)) + 32.0F;
        }
        #endregion

        #region "Métodos públicos"
            public bool Calcular()
            {
                if (!Validar()) { return false; }

                try
                {
                    this.Convertir();
                    fltPresion = fltPresion * 23.0F;

                    fltMasa = (fltPresion * fltVolumen) / ((fltTemperatura + 460.0F) * 0.37F);
                    return true;
                }
                catch (Exception ex)
                {

                    strError = ex.Message;
                    return false;
                }
            }
        #endregion
    }
}
