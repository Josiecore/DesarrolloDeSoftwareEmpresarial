using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lblSueldoDiario
{
    public class clsSueldoDiario
    {
        #region "Atributos"
            private int intDia;
            private float fltHorasDiurnas, fltHorasNocturnas, fltSalario, fltHoraNormal;
            private string strError;
        #endregion

        #region "Propiedades"
            public int Dia { set { this.intDia = value; } }
            public float HorasDiurnas { set { this.fltHorasDiurnas = value; } }
            public float HorasNocturnas { set { this.fltHorasNocturnas = value; } }
            public float HoraNormal { set { this.fltHoraNormal = value; } }
            public float Salario { get { return this.fltSalario; } }
            public string Error { get { return strError; } }
        #endregion

        #region "Constructor"
            public clsSueldoDiario()
            {
                this.intDia = 0;
                this.fltHorasDiurnas = 0.0F;
                this.fltHorasNocturnas = 0.0F;
                this.fltSalario = 0.0F;
            }
        #endregion

        #region "Métodos privados"

        private bool Validar()
        {
            if (intDia <= 0)
            {
                this.strError = "Día no válido.";
                return false;
            }

            if (((fltHorasDiurnas < 0.0F) || (fltHorasNocturnas < 0.0F)) || ((fltHorasDiurnas == 0.0F) && (fltHorasNocturnas == 0.0F)))
            {
                this.strError = "Horas diurnas o nocturnas, no válidas";
                return false;
            }

            if (fltHoraNormal <= 0)
            {
                this.strError = "Valor de hora normal, no válido";
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

                    switch (intDia)
                    {
                        case 1:
                        case 2:
                            fltSalario = (((fltHoraNormal + (fltHoraNormal * 0.50F)) * fltHorasDiurnas) + ((fltHoraNormal + (fltHoraNormal * 0.75F)) * fltHorasNocturnas)); break;
                        default:
                            fltSalario = (fltHoraNormal * fltHorasDiurnas) + ((fltHoraNormal + (fltHoraNormal * 0.32F)) * fltHorasNocturnas); break;
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
