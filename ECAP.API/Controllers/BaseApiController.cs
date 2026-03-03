using Microsoft.AspNetCore.Mvc;

namespace ECAP.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public abstract class BaseApiController : ControllerBase
{
}