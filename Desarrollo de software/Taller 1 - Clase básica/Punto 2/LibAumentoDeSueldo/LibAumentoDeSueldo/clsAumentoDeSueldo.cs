using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAumentoDeSueldo
{
    public class clsAumentoDeSueldo
    {
        #region "Atributos"
            private float fltSueldo, fltPorcentajeDeAumento, fltMontoDelAumento;
            private int intExperiencia;
            private string strError;
        #endregion

        #region "Propiedades"
            public float Sueldo { set { fltSueldo = value; } }
            public int Experiencia { set { intExperiencia = value; } }
            public float PorcentajeAumento { get { return fltPorcentajeDeAumento; } }
            public float MontoDelAumento { get { return fltMontoDelAumento; } }
            public string Error { get { return strError; } }
        #endregion

        #region "Constructor"
            public clsAumentoDeSueldo()
            {
                fltSueldo = 0.0F;
                fltPorcentajeDeAumento = 0.0F;
                fltMontoDelAumento = 0.0F;
                intExperiencia = 0;
                strError = String.Empty;

            }
        #endregion

        #region "Métodos privados"
            public bool Validar()
            {
                if (fltSueldo <= 0)
                {
                    strError = "Sueldo no válido. No puede ser negativo o igual a cero.";
                    return false;
                }

                if (intExperiencia < 0)
                {
                    strError = "Experiencia no válida. ¿Años negativos?";
                    return false;
                }

                return true;
            }
        #endregion

        #region "Métodos públicos"
            
            public bool CalcularAumento()
            {   
                if (!Validar())
                {
                    return false;
                }
                try
                {
                    if (fltSueldo <= 700000.0F)
                    {
                        if (intExperiencia < 5)
                        {
                            fltPorcentajeDeAumento = 4.55F;
                        }
                        else
                        {
                            fltPorcentajeDeAumento = 4.95F;
                        }

                        fltMontoDelAumento = fltSueldo * (fltPorcentajeDeAumento / 100.0F);
                    }
                    else if (fltSueldo > 700000.0F && fltSueldo <= 2500000.0F ) 
                    {
                        if (intExperiencia < 8)
                        {
                            fltPorcentajeDeAumento = 4.6F;
                            fltMontoDelAumento = fltSueldo * (fltPorcentajeDeAumento / 100.0F);
                    }
                        else
                        {
                            intExperiencia = intExperiencia - 5;
                            intExperiencia = intExperiencia / 3;
                            

                            if (intExperiencia >= 1)
                            {
                                fltPorcentajeDeAumento = 2.71F;
                                fltMontoDelAumento = fltSueldo * ((fltPorcentajeDeAumento * intExperiencia) / 100.0F);
                            }

                         }    
                    }
                    else
                    {
                        if (intExperiencia < 8)
                        {
                            fltPorcentajeDeAumento = 4.3F;
                            fltMontoDelAumento = fltSueldo * (fltPorcentajeDeAumento / 100.0F);
                        }
                        else
                        {
                            intExperiencia = intExperiencia - 5;
                            intExperiencia = intExperiencia / 3;

                            if (intExperiencia >= 1)
                            {
                                fltPorcentajeDeAumento = 2.5F;
                                fltMontoDelAumento = fltSueldo * ((fltPorcentajeDeAumento * intExperiencia) / 100.0F);
                            }

                         }    
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
