using Infrastructure.Filters;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[UseApiKey]
public class CoursesController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateCourse()
    {
        return Ok();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetOneCourse()
    {
        return Ok();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllCourses()
    {
        return Ok();
    }

    [HttpPatch]
    public async Task<IActionResult> UpdateCoruse()
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCourse()
    {
        return Ok();
    }
}
