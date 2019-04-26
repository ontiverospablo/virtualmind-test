using System;
using System.Net;
using System.Net.Http;
using VirtualMindTest.Intefaces;

namespace VirtualMindTest
{
    internal class CotizacionReal : ICotizacion
    {
        public HttpResponseMessage Ejecutar(HttpRequestMessage Request)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetStringAsync(new Uri(@"http://www.bancoprovincia.com.ar/Principal/Dolar"))
                    .Result;

                return Request.CreateErrorResponse(HttpStatusCode.OK, response);
            }
        }
    }
}