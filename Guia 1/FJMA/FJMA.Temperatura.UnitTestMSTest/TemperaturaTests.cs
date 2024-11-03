using Microsoft.VisualStudio.TestTools.UnitTesting;
using FJMA.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FJMA.Temperatura.Tests
{
    [TestClass()]
    public class TemperaturaTests
    {
        [TestMethod()]
        public void CelsiusAFahrenheitTest()
        {
            Temperatura temp = new Temperatura();
            double result = temp.CelsiusAFahrenheit(0);
            Assert.AreEqual(32, result);
        }

        [TestMethod()]
        public void FahrenheitACelsiusTest()
        {
            Temperatura temp = new Temperatura();
            double result = temp.FahrenheitACelsius(32);
            Assert.AreEqual(0, result);
        }
    }
}