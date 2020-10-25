using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace Modelo.MetodosExtension
{
    public static class CalculoExtensions
    {
        #region Metodos Publicos 

        // METODOS QUE EXTIENDEN LA FUNCIONALIDAD DE LA CLASE CALCULO.

        public static int SumarPorcentaje(this Calculo calculo, int numero, int porcentaje) {
            int porcentajeAsumar = (numero * porcentaje) / 100;
            int resultado = numero + porcentajeAsumar;
            return resultado;
        }

        public static int RestarPorcentaje(this Calculo calculo, int numero, int porcentaje) {
            int porcentajeArestar = (numero * porcentaje) / 100;
            int resultado = numero - porcentajeArestar;
            return resultado;
        }

        public static int CalcularPotencia (this Calculo calculo, int numero, int exponente) {
            int resultado = numero;

            for (int i = 1; i < exponente; i++) {
                resultado *= numero;
            }
            return resultado;
        }

        public static bool EsPar(this Calculo calculo, int numero) {         
            int division = numero % 2;
            return division == 0;
        }

        #endregion

    }
}
