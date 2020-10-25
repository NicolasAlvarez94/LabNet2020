using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Tests
{
    [TestClass()]
    public class CalculoTests
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void IngreseDivisorParaCalculoAleatorioTest() {
            // ARRANGE (INICIALIZACION DE VARIABLES).            
            var objCalculo = new Calculo();            
            int divisor = 0;

            // ACT (SERVICIO A LLAMAR - METODO A TESTEAR).            
            objCalculo.IngreseDivisorParaCalculoAleatorio(divisor);
        }


        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void CalcularDivisionTest() {                     
            int divisor = 0;
            int dividendo = 10;
            Calculo objCalculo = new Calculo();
                     
            objCalculo.CalcularDivision(dividendo, divisor);                       
        }




    }
}