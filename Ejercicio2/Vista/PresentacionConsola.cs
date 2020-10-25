using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Excepciones;
using Modelo.MetodosExtension;

namespace Vista
{
    public class PresentacionConsola
    {
        #region Estado
        private Calculo objCalculo;
        private Logic objLogic;
        #endregion


        #region Constructor
        public PresentacionConsola(Calculo calculo, Logic logic) {         
            this.objCalculo = calculo;
            this.objLogic = logic;
        }
        #endregion



        #region Metodos Publicos

        // EJERCICIO 1, EL METODO DE LA CLASE CALCULO PUEDE GENERAR UNA EXCEPCION Y ES CAPTURA EN ESTE METODO DE LA CLASE CONSOLAPRESENTACION.
        public void IngreseDivisorParaCalculoAleatorio(int divisor) {
            try {             
                int resultado = this.objCalculo.IngreseDivisorParaCalculoAleatorio(divisor);
                Console.WriteLine($"EL RESULTADO DE LA OPERACION ES: {resultado}");
            }
            catch (DivideByZeroException ex) {             
                Console.WriteLine($"TIPO DE EXCEPCION: {ex.GetType().FullName} - MENSAJE: {ex.Message}");
            }
            finally {Console.WriteLine("FIN DE LA OPERACION"); }                                   
        }



        // EJERCICIO 2, SE CAPTURA POSIBLE EXCEPCION DE DIVISION POR CERO QUE PUEDE OCURRIR EN EL METODO DE LA CLASE CALCULO Y UN POSIBLE INGRESO INVALIDO.
        public void CalcularDivision() {
            try {             
                Console.Write("INGRESE NUMERO DIVIDENDO: ");
                int dividendo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("INGRESE NUMERO DIVISOR: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                int resultado = objCalculo.CalcularDivision(dividendo, divisor);
                Console.WriteLine($"EL RESULTADO DE LA DIVISION ES: {resultado}");
            }
            catch (DivideByZeroException ex) {             
                Console.WriteLine("SOLO CHUCK NORRIS DIVIDE POR CERO!");
                Console.WriteLine($"TIPO DE EXCEPCION: {ex.GetType().FullName} - MENSAJE: {ex.Message}");
            }
            catch (FormatException ex) {             
                Console.WriteLine("SEGURO INGRESO UNA LETRA O NO INGRESO NADA!");
                Console.WriteLine($"TIPO DE EXCEPCION: {ex.GetType().FullName} - MENSAJE: {ex.Message}");
            }
            finally {Console.WriteLine("FIN DE LA OPERACION"); }
        }



        // EJERCICIO 3, CAPTURA LAS EXCEPCIONES QUE PUEDE DISPARAR EL METODO INVOCADO DE LA CLASE LOGIC 
        public void RealizarOperacion(int numeroOperacion, int numeroA, int numeroB) {
            try {             
                int resultado = this.objLogic.RealizarOperacion(numeroOperacion, numeroA, numeroB);
                Console.WriteLine($"EL RESULTADO DE LA OPERACION ES: {resultado}");
            }
            catch (IndexOutOfRangeException ex) {             
                Console.WriteLine($"TIPO DE EXCEPCION: {ex.GetType().FullName} - MENSAJE: {ex.Message}");
            }
            catch (DivideByZeroException ex) {             
                Console.WriteLine($"TIPO DE EXCEPCION: {ex.GetType().FullName} - MENSAJE: {ex.Message}");
            }
            finally {Console.WriteLine("FIN DE OPERACION"); }                                        
        }


        // EJERCIO 4, CAPTURA LA EXCEPCION PERSONALIZADA DEL METODO INVOCADO DE LA CLASE LOGIC
        public void RealizarOperacionB(int numeroOperacion, int numeroA, int numeroB) {
            try {             
                int resultado = this.objLogic.RealizarOperacionB(numeroOperacion, numeroA, numeroB);
                Console.WriteLine($"EL RESULTADO DE LA OPERACION ES: {resultado}");
            }
            catch (ExceptionNumeroOperacionInvalida ex) {             
                Console.WriteLine($"TIPO DE EXCEPCION: {ex.GetType().FullName} - MENSAJE: {ex.Message}");
            }
            catch (DivideByZeroException ex) {             
                Console.WriteLine($"TIPO DE EXCEPCION: {ex.GetType().FullName} - MENSAJE: {ex.Message}");
            }
            finally {Console.WriteLine("FIN DE OPERACION"); }                                    
        }




        // PRUEBA DE INVOCACION A METODOS DE EXTENSION DE LA CLASE CALCULO.

        public void SumarPorcentaje(int numero, int porcentaje) {         
            int resultado = this.objCalculo.SumarPorcentaje(numero, porcentaje);
            Console.WriteLine($"EL RESULTADO DE LA SUMA DE PORCENTAJE ES: {resultado}");
        }


        public void RestarPorcentaje(int numero, int porcentaje) {                   
            int resultado = this.objCalculo.RestarPorcentaje(numero, porcentaje);
            Console.WriteLine($"EL RESULTADO DE LA RESTA DE PORCENTAJE ES: {resultado}");
        }

        public void CalcularPotencia(int numero, int exponente) {         
            int resultado = this.objCalculo.CalcularPotencia(numero, exponente);
            Console.WriteLine($"EL RESULTADO DE POTENCIA ES: {resultado}");
        }

        public void EsPar(int numero) {         
            bool resultado = this.objCalculo.EsPar(numero);
            if (resultado)
                Console.WriteLine("EL NUMERO ES PAR");
            else
                Console.WriteLine("EL NUMERO NO ES PAR");            
        }

        #endregion
    }
}
