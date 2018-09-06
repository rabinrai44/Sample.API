using Sample.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Sample.API.Controllers
{
    //[RoutePrefix("HelloWorld")]
    public class HelloWorldController : ApiController
    {
        private HelloWorld _testHelloWorld;

        public HelloWorldController(HelloWorld helloWorld)
        {
            _testHelloWorld = helloWorld;
        }

        [HttpGet]
        [Route("api/HelloWorld/hello")]
        public async Task<HttpResponseMessage> Get()
        {
            var hello = await _testHelloWorld.GetHelloWorld();
            return Request.CreateResponse(HttpStatusCode.OK, hello);
        }
    }
}
