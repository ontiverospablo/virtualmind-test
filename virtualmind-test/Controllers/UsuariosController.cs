using System.Collections.Generic;
using System.Web.Http;
using NPoco;
using VirtualMindTest.Models;

namespace VirtualMindTest.Controllers
{
    public class UsuariosController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<User> Get()
        {
            using (var db = new Database(@"Data Source=.\SQL2017;User Id=sa;Password=sa12345; Initial Catalog=virtualmind",DatabaseType.SqlServer2012))
            {
                return db.Fetch<User>("SELECT * FROM [User]");
            }
        }

    }
}