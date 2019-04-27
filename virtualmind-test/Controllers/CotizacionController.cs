using System.Net.Http;
using System.Web.Http;
using VirtualMindTest.Intefaces;

namespace VirtualMindTest
{
    public class CotizacionController : ApiController
    {
        public HttpResponseMessage Get(string id)
        {
            ICotizacion cotizacion = null;

            switch (id.ToLower())
            {
                case "dolar":
                    cotizacion = new CotizacionDolar();
                    break;
                case "pesos":
                    cotizacion = new CotizacionPesos();
                    break;
                case "real":
                    cotizacion = new CotizacionReal();
                    break;
            }

            return cotizacion.Ejecutar();
        }
    }
}