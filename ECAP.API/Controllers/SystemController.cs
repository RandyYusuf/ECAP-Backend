using Microsoft.AspNetCore.Mvc;
using ECAP.Application.Wrappers;

namespace ECAP.API.Controllers;

public class SystemController : BaseApiController
{
    [HttpGet("health")]
    public ActionResult<ApiResponse<string>> GetHealthStatus()
    {
        var response = ApiResponse<string>.Ok("Server is running perfectly.", "Healthy");
        return Ok(response);
    }
}