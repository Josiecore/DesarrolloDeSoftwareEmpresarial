using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibConversorDeTemperatura
{
    public class ClsConversorDeTemperatura
    {
        #region "Atributos" 

            private float fltTemperatura;
            private int intEscalaDeEntrada, intEscalaDeSalida;
            private string strError;

        #endregion

        #region "Propiedades" 
            public float Temperatura
            {
                set{  fltTemperatura = value; }
                get { return fltTemperatura; }
            }
            
            public int EscalaDeEntrada
            {
                set { intEscalaDeEntrada = value; }
            }

            public int EscalaDeSalida
            {
                set { intEscalaDeSalida = value; }
            }

            
            public string Error
            {
                get { return strError; }
            }
        #endregion

        #region "Constructor"
            public ClsConversorDeTemperatura()
            {
                fltTemperatura = 0;
                intEscalaDeEntrada = 0;
                intEscalaDeSalida = 0;
                strError = String.Empty;
            }
        #endregion

        #region "Métodos privados"

            private bool Validar()
            {
                if (intEscalaDeEntrada < 1 || intEscalaDeEntrada > 4)
                {
                    strError = "No ha seleccionado una escala de grados de entrada válida";
                    return false;
                }

                if (intEscalaDeSalida < 1 || intEscalaDeSalida > 4)
                {
                    strError = "No ha seleccionado una escala de grados válida";
                    return false;
                }

                return true;
            }

        #endregion

        #region "Métodos públicos"
           public bool Convertir()
           {
                if (!Validar())
                {
                    return false;    
                }

                try
                {
                    switch (intEscalaDeEntrada)
                    {
                        case 2:
                            fltTemperatura = (5 * (fltTemperatura - 32)) / 9.0F; break;

                        case 3:
                            fltTemperatura = fltTemperatura - 273.15F; break;

                        case 4:
                            fltTemperatura = (5 / 9.0F) * (fltTemperatura - 491.67F); break;

                    }

                    switch (intEscalaDeSalida)
                    {
                        case 2:
                            fltTemperatura = ((9 / 5.0F) * fltTemperatura) + 32.0F; break;

                        case 3:
                            fltTemperatura = fltTemperatura + 273.15F; break;

                        case 4:
                            fltTemperatura = (9 / 5.0F) * fltTemperatura + 491.67F; break;
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
