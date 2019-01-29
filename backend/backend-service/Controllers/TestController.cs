using System.Web.Http;

namespace backend_service.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Hello(string id)
        {         
            return Ok($"Hello, {id}");
        }
    }
}
