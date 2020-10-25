using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo.MetodosExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.MetodosExtension.Tests
{
    [TestClass()]
    public class CalculoExtensionsTests
    {

        [TestMethod()]
        public void SumarPorcentajeTest() {         
            // ARRANGE.
            int numero = 100;
            int porcentaje = 50;
            var objCalculo = new Calculo();

            // ACT.
            int resultado = objCalculo.SumarPorcentaje(numero, porcentaje);

            // ASSERT
            Assert.AreEqual(resultado, 150);
        }


        [TestMethod()]
        public void RestarPorcentajeTest() {         
            int numero = 1000;
            int porcentaje = 50;
            var objCalculo = new Calculo();

            int resultado = objCalculo.RestarPorcentaje(numero, porcentaje);

            Assert.AreEqual(resultado, 500);
        }


        [TestMethod()]
        public void CalcularPotenciaTest() {         
            int numero = 2;
            int exponente = 4;
            var objCalculo = new Calculo();

            int resultado = objCalculo.CalcularPotencia(numero, exponente);

            Assert.AreEqual(resultado, 16);
        }


        [TestMethod()]
        public void EsParTest() {         
            int numero = 4;
            var objCalculo = new Calculo();

            bool resultado = objCalculo.EsPar(numero);
            Assert.IsTrue(resultado);
        }
    }
}