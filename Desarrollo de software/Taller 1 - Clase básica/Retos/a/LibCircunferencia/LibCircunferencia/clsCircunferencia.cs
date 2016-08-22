using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCircunferencia
{
    public class clsCircunferencia
    {
        #region "Atributos"
            private double dblX1, dblY1, dblX2, dblY2, dblRadio;
            private string strError, strRespuesta;
        #endregion

        #region "Propiedades"
            public double PuntoX1 { set { dblX1 = value; } }
            public double PuntoY1 { set { dblY1 = value; } }
            public double PuntoX2 { set { dblX2 = value; } }
            public double PuntoY2 { set { dblY2 = value; } }
            public double Radio { set { dblRadio = value ; } }
            public string Respuesta { get { return strRespuesta; } }
            public string Error { get { return strError; } }
        #endregion

        #region "Constructor"
        public clsCircunferencia()
        {
            this.dblX1 = 0.0;
            this.dblX2 = 0.0;
            this.dblY1 = 0.0;
            this.dblY2 = 0.0;
            this.dblRadio = 0.0;
            this.strError = string.Empty;
            this.strRespuesta = string.Empty;
        }
        #endregion

        #region "Métodos públicos"
        private bool Validar()
            {
                if (dblRadio < 0)
                {
                    strError = "El radio por definición no puede ser negativo";
                    return false;
                }

                 return true;
            }
        #endregion

        #region "Métodos públicos"

        public bool Calcular()
        {
            if (!Validar()) { return false; }

            try
            {
                double dblDistancia;
                dblDistancia = Math.Sqrt(Math.Pow((dblX1 - dblX2), 2.0) + Math.Pow((dblY1 - dblY2), 2.0));

                if (dblDistancia > dblRadio)
                {
                    strRespuesta = "No.";
                }
                else
                {
                    strRespuesta = "Sí.";
                }

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
