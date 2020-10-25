using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using Modelo.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RealizarOperacionTest() {         
            var objLogic = new Logic();
            int numeroOperacion = 5;
            int numeroA = 10;
            int numeroB = 10;

            objLogic.RealizarOperacion(numeroOperacion, numeroA, numeroB);
        }

        [TestMethod()]
        [ExpectedException(typeof(ExceptionNumeroOperacionInvalida))]
        public void RealizarOperacionBTest() {
            var objLogic = new Logic();
            int numeroOperacion = 5;
            int numeroA = 100;
            int numeroB = 10;

            objLogic.RealizarOperacionB(numeroOperacion, numeroA, numeroB);
        }
    }
}