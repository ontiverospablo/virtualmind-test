using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using FluentAssertions;
using VirtualMindTest;

namespace virtualmind_test.Tests
{
    [TestClass]
    public class CotizacionTest
    {
        [TestMethod]
        public void CotizacionPesos()
        {
            var controller = new CotizacionController();
            var result = controller.Get("pesos");
            var expected = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            result.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void CotizacionDolar()
        {
            var controller = new CotizacionController();
            var result = controller.Get("dolar");
            var expected = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            result.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void CotizacionReal()
        {
            var controller = new CotizacionController();
            var result = controller.Get("real").Content;

            using (var client = new HttpClient())
            {
                var expected = client.GetAsync(new Uri(@"http://www.bancoprovincia.com.ar/Principal/Dolar")).Result.Content;
                result.Should().BeEquivalentTo(expected);
            }
        }


    }
}
