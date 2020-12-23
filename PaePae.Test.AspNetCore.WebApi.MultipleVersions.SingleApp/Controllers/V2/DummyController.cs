using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PaePae.Test.AspNetCore.WebApi.MultipleVersions.SingleApp.Controllers.V2
{
    [ApiController]
    [Route("api/v2/dummy")]
    public class DummyController : ControllerBase
    {
        private readonly ILogger<DummyController> logger;

        public DummyController(ILogger<DummyController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public string Index()
        {
            return "Hello V2";
        }
    }
}
