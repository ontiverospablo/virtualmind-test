using System.Net.Http;

namespace VirtualMindTest.Intefaces
{
    interface ICotizacion
    {
        HttpResponseMessage Ejecutar();
    }
}
