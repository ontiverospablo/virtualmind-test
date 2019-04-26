using System.Net;
using System.Net.Http;
using VirtualMindTest.Intefaces;

namespace VirtualMindTest
{
    internal class CotizacionDolar : ICotizacion
    {
        public HttpResponseMessage Ejecutar(HttpRequestMessage Request)
        {
            return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "No autorizado");
        }
    }
}