using Microsoft.AspNetCore.Mvc;
using Asp.Versioning;


namespace AccessManagement.Controllers.v2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class AccessV2Controller : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new[] { "value1", "value2", "value3" }; // New behavior for version 2.0
    }
}
