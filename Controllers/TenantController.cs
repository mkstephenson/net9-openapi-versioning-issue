using Microsoft.AspNetCore.Mvc;

namespace TestVersionedApiWithOpenAPI.Controllers
{
  [Route("api/{tenant}/[controller]")]
  [ApiController]
  public class TenantController : ControllerBase
  {
    [HttpGet]
    public ActionResult Get()
    {
      return new OkResult();
    }
  }
}
