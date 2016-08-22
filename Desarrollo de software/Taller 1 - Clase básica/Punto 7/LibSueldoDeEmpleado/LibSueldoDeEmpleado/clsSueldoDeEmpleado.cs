using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibSueldoDeEmpleado
{
    public class clsSueldoDeEmpleado
    {
        #region "Atributos"

            private int intExperiencia;
            private string strNombre, strPrimerApellido, strSegundoApellido, strError;
            private float fltSalarioBase, fltSueldoBrutoNormal, fltSueldoNetoNormal, fltValorEuro;
            private float fltSueldoBrutoExtra, fltSueldoNetoExtra;
            private float fltSueldoBrutoTotal, fltSueldoNetoTotal;
        #endregion

        #region "Propiedades"
            
            public int Experiencia { set { intExperiencia = value; } }

            public string Nombre
            {
                  set { strNombre = value; }
                  get { return strNombre; }
            }

            public string PrimerApellido
            {
                  set { strPrimerApellido = value; }
                  get { return strPrimerApellido; }
            }

            public string SegundoApellido
            {
                set { strSegundoApellido = value; }
                get { return strSegundoApellido; }
            }

            public string Error { get { return strError; } }
            public float SueldoBase { set { fltSalarioBase = value; } }
            public float Euro { set { fltValorEuro = value; } }
            public float SueldoBrutoNormal { get { return fltSueldoBrutoNormal; } }
            public float SueldoNetoNormal { get { return fltSueldoNetoNormal; } }
            public float SueldoBrutoExtra { get { return fltSueldoBrutoExtra; } }
            public float SueldoNetoExtra { get { return fltSueldoNetoExtra; } }
            public float SueldoBrutoTotal { get { return fltSueldoBrutoTotal; } }
            public float SueldoNetoTotal { get { return fltSueldoNetoTotal; } }

        #endregion

        #region "Constructor"
        public clsSueldoDeEmpleado()
        {
            this.intExperiencia = 0;
            this.strNombre = string.Empty;
            this.strPrimerApellido = string.Empty;
            this.strSegundoApellido = string.Empty;
            this.fltSalarioBase = 0.0F;
            this.fltSueldoBrutoNormal = 0.0F;
            this.fltSueldoNetoNormal = 0.0F;
            this.fltSueldoBrutoExtra = 0.0F;
            this.fltSueldoNetoExtra = 0.0F;
            this.fltSueldoBrutoTotal = 0.0F;
            this.fltSueldoNetoTotal = 0.0F;
            this.fltValorEuro = 0.0F;
            this.strError = string.Empty;
        }
        #endregion

        #region "Métodos privados"
        private bool Validar()
        {
            if (this.strNombre == string.Empty)
            {
                this.strError = "El campo nombre no puede estar vacío";
                return false;
            }

            if (this.strPrimerApellido == string.Empty)
            {
                this.strError = "El campo del primero apellido no puede estar vácío";
                return false; 
            }

            if (this.strSegundoApellido == string.Empty)
            {
                strError = "El campo del segundo apellido no puede estar vacío";
                return false;
            }

            if (this.fltSalarioBase <= 0.0F)
            {
                this.strError = "El campo del salario base no es válido";
                return false;
            }

            return true;
        }

        private bool CalcularIncremento()
        {
            try
            {
                if (intExperiencia < 3)
                {
                    this.fltSueldoBrutoNormal = 0.05F;
                }

                else if (intExperiencia >= 3 && intExperiencia < 5)
                {
                    this.fltSueldoBrutoNormal = 0.10F;
                }

                else if (intExperiencia >= 5 && intExperiencia < 8)
                {
                    this.fltSueldoBrutoNormal = 0.15F;
                }

                else
                {
                    this.fltSueldoBrutoNormal = 0.20F;
                }

                fltSueldoBrutoNormal = (fltSalarioBase + (fltSalarioBase * fltSueldoBrutoNormal));
                return true;

            }
            catch (Exception ex)
            {

                strError = "Ocurrió un error: " + ex.Message;
                return false;
            }
        }

        private float CalcularRetenciones(float fltSueldo)
        {
            if (fltSueldo < 900.0F) { return (fltSueldo - (fltSueldo * 0.1255F)); }
            if (fltSueldo >= 900.0F && fltSueldo < 1300.0F) { return fltSueldo - (fltSueldo * 0.1625F); }
            if (fltSueldo >= 1300.0F && fltSueldo < 1800.0F) { return fltSueldo - (fltSueldo * 0.1995F); }

            return fltSueldo - (fltSueldo * 0.2365F);
        }
        #endregion

        #region "Métodos públicos"
        public bool CalcularSalario()
        {
            if (!Validar()) { return false; }

            try
            {
                if (!CalcularIncremento()) { return false; }

                fltSueldoNetoNormal = this.CalcularRetenciones(fltSueldoBrutoNormal);
                fltSueldoBrutoExtra = fltSueldoBrutoNormal + fltSalarioBase;
                fltSueldoNetoExtra = this.CalcularRetenciones(fltSueldoBrutoExtra);
                fltSueldoBrutoTotal = (fltSueldoBrutoNormal * 10) + (fltSueldoBrutoExtra * 2);
                fltSueldoNetoTotal = (fltSueldoNetoNormal * 10) + (fltSueldoNetoExtra * 2);

                fltSueldoBrutoNormal = fltSueldoBrutoNormal * fltValorEuro;
                fltSueldoNetoNormal = fltSueldoNetoNormal * fltValorEuro;
                fltSueldoBrutoExtra = fltSueldoBrutoExtra * fltValorEuro;
                fltSueldoNetoExtra = fltSueldoNetoExtra * fltValorEuro;
                fltSueldoBrutoTotal = fltSueldoBrutoTotal * fltValorEuro;
                fltSueldoNetoTotal = fltSueldoNetoTotal * fltValorEuro;

                strPrimerApellido = strPrimerApellido.Substring(0,1);
                strSegundoApellido = strSegundoApellido.Substring(0,1);

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
