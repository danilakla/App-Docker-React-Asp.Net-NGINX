using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult GetUser()
    {
        var users = new[]{
             new { Name = "Danila" },
                          new { Name = "Test" }
        };
        return Ok(users);   
    }
}
