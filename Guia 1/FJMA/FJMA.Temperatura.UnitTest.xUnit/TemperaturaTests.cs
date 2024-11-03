using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FJMA.Temperatura.UnitTest.xUnit
{
    public class TemperaturaTests
    {
        [Fact]
        public void CelsiusToFarenheit()
        {
            Temperatura temp = new Temperatura();
            double celsius = 0.0;
            double result = temp.CelsiusAFahrenheit(celsius);
            Assert.Equal(32.0, result);
        }

        [Fact]
        public void FarenheitToCelsius()
        {
            Temperatura temp = new Temperatura();
            double farenheit = 32.0;
            double result = temp.FahrenheitACelsius(farenheit);
            Assert.Equal(0.0, result);
        }
    }
}
