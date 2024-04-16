using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Subscribe()
    {
        if (ModelState.IsValid)
        {
            
            return Ok();
        }

        return BadRequest();

        
    }

    [HttpDelete]
    public async Task<IActionResult> Unsubscribe()
    {
        return Ok();
    }
}
