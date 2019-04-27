using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VirtualMindTest.Intefaces;

namespace VirtualMindTest
{
    internal class CotizacionReal : ICotizacion
    {
        public HttpResponseMessage Ejecutar()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(new Uri(@"http://www.bancoprovincia.com.ar/Principal/Dolar"))
                    .Result;

                return response;
            }
        }
    }
}