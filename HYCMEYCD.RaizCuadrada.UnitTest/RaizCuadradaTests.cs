using Microsoft.VisualStudio.TestTools.UnitTesting;
using HYCMEYCD20241028;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HYCMEYCD20241028.Tests
{
    [TestClass()]
    public class RaizCuadradaTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalcularRaizCuadrada_Negativo()
        {
            RaizCuadrada raizCuadrada = new RaizCuadrada();
            raizCuadrada.Raiz(-2);
        }

        [TestMethod]
        public void CalcularRaizCuadrada_Positivo()
        {
            RaizCuadrada raizCuadrada = new RaizCuadrada();
            double result = raizCuadrada.Raiz(4);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalcularRaizCuadrada_Cero()
        {
            RaizCuadrada raizCuadrada = new RaizCuadrada();
            double result = raizCuadrada.Raiz(0);
            Assert.AreEqual(0, result);
        }
    }
}
