using Modelo.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Logic
    {
        // ARRAY PRIVADO SIN ACCESO DE LECTURA Y ESCRITURA.

        private string[] operaciones;


        #region Constructor
        public Logic() {         
            this.operaciones = new string[] { "SUMA", "RESTA", "MULTIPLICION", "DIVISION" };
        }
        #endregion


        #region Metodos Publicos

        // METODO EJERCICIO 3, PUEDE DISPARAR UNA EXCEPCION DE INDICE FUERA DE RANGO O UNA DIVISION POR CERO, ES CAPTURADA EN LA CLASE PRESENTACIONCONSOLA.
        public int RealizarOperacion (int numeroOperacion, int numeroA, int numeroB) {            
            try {
                int resultado = DeterminarResultadoOperacion(numeroOperacion, numeroA, numeroB);                
                return resultado;
            }
            catch(IndexOutOfRangeException ex) {
                throw ex;
            }
            catch(DivideByZeroException ex) {
                throw ex;
            }
        }


        // METODO EJERCICIO 4, SIMILAR AL METODO DEL EJERCICO 3 PERO SE DISPARA UNA EXCEPCION PERSONALIZADA SI EL NUMERO DE OPERACION ES INVALIDO,
        // SE CAPTURA EN LA CLASE PRESENTACIONCONSOLA.

        public int RealizarOperacionB(int numeroOperacion, int numeroA, int numeroB) {
            int resultado = 0;
            int cantidadOperacionesValidas = this.operaciones.Length - 1;

            if ((numeroOperacion > cantidadOperacionesValidas) || (numeroOperacion < 0)) {             
                throw new ExceptionNumeroOperacionInvalida("NUMERO DE OPERACION INVALIDA");
            }
            else {             
                resultado = DeterminarResultadoOperacion(numeroOperacion, numeroA, numeroB);
            }
            return resultado;
        }

        #endregion




        #region Metodo Privado

        // METODO AUXILIAR PRIVADO PARA DETERMINAR EL RESULTADO DE LA OPERACION.
        private int DeterminarResultadoOperacion(int numeroOperacion, int numeroA, int numeroB) {         
            int resultado = 0;
            string strOperacion = this.operaciones[numeroOperacion];
            switch (strOperacion) {             
                case "SUMA":
                    resultado = numeroA + numeroB;
                    break;
                case "RESTA":
                    resultado = numeroA - numeroB;
                    break;
                case "MULTIPLICACION":
                    resultado = numeroA * numeroB;
                    break;
                case "DIVISION":
                    resultado = numeroA / numeroB;
                    break;
            }
            return resultado;
        }

        #endregion


    }
}
