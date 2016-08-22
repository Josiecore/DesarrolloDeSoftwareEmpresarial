using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFabricaDeZapatos
{
    public class clsFabricaDeZapatos
    {
        #region "Atributos"
        private int intCantidad;
        private float fltCosto, fltCaja, fltValorCajas, fltValorEuro;
        private string strError;
        #endregion

        #region "Propiedades"
        public int Cantidad { set { this.intCantidad = value; } }
        public float Euro { set { this.fltValorEuro = value; } }
        public float Costo
        {
            set { this.fltCosto = value; }
            get { return this.fltCosto; }
        }
        public float Caja
        {
            set { this.fltCaja = value; }
        }

        public float ValorCajas { get { return fltValorCajas; } }
        public string Error { get { return this.strError; } }
        #endregion

        #region "Constructor"
        public clsFabricaDeZapatos()
        {
            this.intCantidad = 0;
            this.fltCaja = 0.0F;
            this.fltCosto = 0.0F;
            this.fltValorCajas = 0.0F;
            this.fltValorEuro = 0.0F;
            this.strError = string.Empty;
        }
        #endregion

        #region "Métodos privados"
        private bool Validar()
        {
            if (intCantidad <= 0)
            {
                this.strError = "Cantidad de pares de zapatos, no válida";
                return false;
            }

            if (fltCaja <= 0)
            {
                this.strError = "Superficie de las cajas no válida";
            }

            if (fltCosto <= 0)
            {
                this.strError = "Costo de producción de zapatos, no válida";
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
                fltCaja = (0.02F * fltCaja);
                fltValorCajas = fltCaja * intCantidad;
                fltCosto = fltCaja + fltCosto;
                fltCosto += (fltCosto * 0.30F);
                fltCosto = fltCosto * fltValorEuro;
                fltValorCajas = fltValorCajas * fltValorEuro;

                return true;                
            }
            catch (Exception ex)
            {

                this.strError = "Error: " + ex.Message;
                return false;
            }
        }
        #endregion
    }
}
