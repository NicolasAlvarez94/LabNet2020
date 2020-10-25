using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class Calculo
    {

        #region Metodos Publicos

        // METODO DEL EJERCICIO 1, PUEDE OCURRIR UNA EXCEPCION DE DIVISION POR CERO, SE CAPTURA EN LA CLASE PRESENTACIONCONSOLA.
        public int IngreseDivisorParaCalculoAleatorio(int divisor) {         
            Random objRandom = new Random();
            int numeroAleatorio = objRandom.Next(1000);         
            int resultadoDivision = numeroAleatorio / divisor;
            return resultadoDivision;             
        }

        // METODO DEL EJERCICIO 2, PUEDE OCURRIR UNA EXCEPCION DE DIVISION POR CERO, SE CAPTURA EN LA CLASE PRESENTACIONCONSOLA.
        public int CalcularDivision(int dividendo, int divisor) {
            int resultado = dividendo / divisor;
            return resultado;
        }

        #endregion
    }
}
