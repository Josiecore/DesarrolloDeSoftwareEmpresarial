using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEcuacionCuadratica
{
    public class clsEcuacionCuadratica
    {
        #region "Atributos"
            private double dblTerminoA, dblTerminoB, dblTerminoC, dblDiscriminante;
            private string strResultado1, strResultado2;
            private string strError;
        #endregion

        #region "Propiedades"
            public double TerminoA { set { dblTerminoA = value; } }
            public double TerminoB { set { dblTerminoB = value; } }
            public double TerminoC { set { dblTerminoC = value; } }
            public string Resultado1 { get { return strResultado1; } }
            public string Resultado2 { get { return strResultado2; } }
            public string Error { get { return strError; } }
        #endregion

        #region "Constructor"
            public clsEcuacionCuadratica()
            {
                dblTerminoA = 0.0F;
                dblTerminoB = 0.0F;
                dblTerminoC = 0.0F;
                strResultado1 = string.Empty;
                strResultado2 = string.Empty;
                dblDiscriminante = 0.0F;
                strError = string.Empty;
            }
        #endregion

        #region "Métodos privados"
        private bool Validar()
        {
            if (dblTerminoA == 0)
            {
                strError = "El término de x^2 no puede ser igual a cero";
                return false;
            }

            return true;
        }

        private void EncontrarDisciminante()
        {
            dblDiscriminante = Math.Pow(dblTerminoB, 2.0) - 4 * dblTerminoA * dblTerminoC;
        }
        #endregion

        #region "Métodos públicos"

            public bool Calcular()
            {
                if (!Validar())
                {
                    return false;
                }

                try
                {
                    this.EncontrarDisciminante();

                    if (dblDiscriminante == 0)
                    {
                        strResultado1 = (-(dblTerminoB / (2 * dblTerminoA))).ToString();
                        strResultado2 = strResultado1;
                    }
                    else if (dblDiscriminante > 0)
                    {
                        strResultado1 = ((-dblTerminoB + Math.Sqrt(dblDiscriminante)) / (2 * dblTerminoA)).ToString();
                        strResultado2 = ((-dblTerminoB - Math.Sqrt(dblDiscriminante)) / (2 * dblTerminoA)).ToString();
                    }
                    else
                    {
                        strResultado1 = (((-Math.Pow(dblTerminoB, 2.0))).ToString()) + " + " + ((Math.Sqrt(-dblDiscriminante)).ToString()) + " i" + "/" + ((2 * dblTerminoA).ToString());
                        strResultado2 = (((-Math.Pow(dblTerminoB, 2.0))).ToString()) + " - " + ((Math.Sqrt(-dblDiscriminante)).ToString()) + " i" + "/" + ((2 * dblTerminoA).ToString());
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    strError = "Ocurrió un error: " + ex.Message;
                    return false;
                }
            }
        #endregion
    }
}
