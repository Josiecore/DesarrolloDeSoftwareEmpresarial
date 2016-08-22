using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVentas
{
    public class clsTienda
    {
        #region "Atributos"
        private float fltPrecioUnitario, fltPrecioTotal;
        private int intCantidad;
        private string strError;
        #endregion

        #region "Propiedades"
        public int Cantidad { set { intCantidad = value; } }
        public float PrecioUnitario { set { fltPrecioUnitario = value; } }
        public float PrecioTotal { get { return fltPrecioTotal; } }
        public string Error { get { return strError; } }
        #endregion

        #region "Constructor"
        public clsTienda()
        {
            this.fltPrecioUnitario = 0.0F;
            this.intCantidad = 0;
            this.fltPrecioTotal = 0.0F;
            this.strError = string.Empty;
        }
        #endregion

        #region "Métodos privados"
        private bool Validar()
        {
            if (intCantidad <= 0)
            {
                strError = "Cantidad no válida";
                return false;
            }

            if (fltPrecioUnitario <= 0)
            {
                strError = "Precio unitario no válido";
                return false;
            }

            return true;
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
                if (intCantidad < 5)
                {
                    fltPrecioTotal = 0.05F;
                }
                else if (intCantidad < 10)
                {
                    fltPrecioTotal = 0.15F;
                }
                else
                {
                    fltPrecioTotal = 0.15F;
                }

                fltPrecioTotal = (intCantidad * fltPrecioUnitario) * fltPrecioTotal;
                fltPrecioTotal = (intCantidad * fltPrecioUnitario) - fltPrecioTotal;
                
                return true;
            }
            catch (Exception ex)
            {

                strError = "Error: " + ex.Message;
                return false;
            }
        }
        #endregion
    }
}
