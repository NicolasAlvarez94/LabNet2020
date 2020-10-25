using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.MetodosExtension;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {

            // PRUEBA DE EJERCICIOS.
            Logic objLogic = new Logic();
            Calculo objCalculo = new Calculo();

            PresentacionConsola objPresentacionConsola = new PresentacionConsola(objCalculo, objLogic);

            // EJERCICIO 1.
            objPresentacionConsola.IngreseDivisorParaCalculoAleatorio(0);
            Console.WriteLine();

            // EJERCICIO 2.
            objPresentacionConsola.CalcularDivision();
            Console.WriteLine();

            // EJERCICIO 3.
            objPresentacionConsola.RealizarOperacion(8, 8, 4);
            Console.WriteLine();

            // EJERCICIO 4.
            objPresentacionConsola.RealizarOperacionB(6, 5, 4);
            Console.WriteLine();


            // PRUEBA METODO DE EXTENSION DE LA CLASE CALCULO.
            objPresentacionConsola.SumarPorcentaje(100, 50);
            objPresentacionConsola.RestarPorcentaje(100, 50);
            objPresentacionConsola.CalcularPotencia(2, 3);
            objPresentacionConsola.EsPar(3);
                
            Console.ReadKey();
        }
    }
}
