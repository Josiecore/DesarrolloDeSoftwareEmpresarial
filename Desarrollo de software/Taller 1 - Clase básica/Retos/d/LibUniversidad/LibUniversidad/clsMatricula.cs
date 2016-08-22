using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibUniversidad
{
    public class clsMatricula
    {
        #region "Atributos"
            private float fltPromedio, fltTotal;
            private int intTipo, intCreditos;
            private string strError;
        #endregion

        #region "Propiedades"
            public float Promedio { set { this.fltPromedio = value; } }
            public int Tipo { set { this.intTipo = value; } }
            public int Creditos { get { return this.intCreditos; } }
            public float Total { get { return this.fltTotal; } }
            public string Error { get { return this.strError; } }
        #endregion

        #region "Constructor"
            public clsMatricula()
            {
                intTipo = 0;
                intCreditos = 0;
                fltPromedio = 0.0F;
                fltTotal = 0.0F;
                strError = string.Empty;
            }
        #endregion

        #region "Método privado"
        private bool Validar()
        {
            if (intTipo <= 0)
            {
                strError = "Seleccione un tipo de estudiante válido (pregrado o posgrado)";
                return false;
            }

            if (fltPromedio <= 2.5F)
            {
                strError = "El promedio es menor a 2.5, el estudiante no puede matricularse";
                return false;
            }

            return true;
        }
        #endregion

        #region "Métodos privados"
            public bool Calcular()
            {
                if (!Validar()) { return false; }

                try
                {

                    switch (intTipo)
                    {
                        case 1:
                            if (fltPromedio >= 4.5F)
                            {
                                intCreditos = 28;
                                fltTotal = 0.25F;
                            }
                            else if ( fltPromedio >= 4.0F && fltPromedio < 4.5F)
                            {
                                intCreditos = 25;
                                fltTotal = 0.10F; 
                            }
                            else if( fltPromedio >= 3.5F && fltPromedio < 4.0F)
                            {
                                intCreditos = 20;
                            }
                            else
                            {
                                intCreditos = 15;
                            }

                            fltTotal = (50000.0F * intCreditos) - ((50000.0F * intCreditos) * fltTotal);
                            break;

                        default:
                            if( fltPromedio >= 4.5F)
                            {
                                intCreditos = 20;
                                fltTotal = 0.20F;
                            } 
                            else
                            {
                                intCreditos = 10;
                            }

                            fltTotal = (300000.0F * intCreditos) - ((300000.0F * intCreditos) * fltTotal);
                            break;
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
