using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFruteria
{
    public class clsFruteria
    {
        #region "Atributos"
            private int intCantidad;
            private float fltValorUnitario;
            private float fltValorIVA;
            private float fltValorAPagar;
            private string strError;
        #endregion

        #region "Propiedades"
            public int Cantidad { set { intCantidad = value; } }
            public float ValorUnitario { set { fltValorUnitario = value; } }
            public float IVA { set { fltValorIVA = value; } }
            public float ValorAPagar { get { return fltValorAPagar; } }
            public string Error { get { return strError; } }
        #endregion

        #region "Constructor"
            public clsFruteria()
            {
                intCantidad = 0;
                fltValorUnitario = 0.0F;
                fltValorIVA = 0.0F;
                fltValorAPagar = 0.0F;
                strError = string.Empty;
            }
        #endregion

        #region "Métodos privados"
            private bool Validar()
            {
                if (intCantidad < 1)
                {
                    strError = "Cantidad no válida";
                    return false;        
                }

                if(fltValorUnitario <= 0)
                {
                    strError = "Cantidad inválida. ¿Está regalando frutas?";
                    return false;
                }

                if(fltValorIVA < 0)
                {
                    strError = "IVA no válido. ¿IVA negativo?";
                    return false;
                }
                return true;
            }
        #endregion

        #region "Métodos públicos"
        public bool Calcular()
        {
            float fltDescuento;

            if (!Validar())
            {
                return false;
            }

            try
            {
                if (intCantidad <= 12)
                {
                    fltDescuento = 0.0F;
                }
                else if (intCantidad <= (12 * 2))
                {
                    fltDescuento = 0.10F;
                }
                else if (intCantidad <= (12 * 3))
                {
                    fltDescuento = 0.15F;
                }

                else
                {
                    fltDescuento = 0.20F;
                }

                fltValorAPagar = intCantidad * fltValorUnitario;
                fltValorAPagar += fltValorAPagar * (fltValorIVA/100);
                fltValorAPagar -= fltValorAPagar * fltDescuento;

                return true;
            }
            catch (Exception ex)
            {

                strError = "Sucedió un error: " + ex.Message;
                return false;
            }

            
        }
        #endregion
    }
}
