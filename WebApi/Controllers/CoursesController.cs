using Infrastructure.Context;
using Infrastructure.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[UseApiKey]
public class CoursesController(ApiContext context) : ControllerBase
{

    private readonly ApiContext _context = context;

    [HttpPost]
    public async Task<IActionResult> CreateCourse()
    {
        return Ok();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetOneCourse(int Id)
    {
        if (ModelState.IsValid)
        {
            var Course = await _context.Courses.FirstOrDefaultAsync(x => x.Id == Id);
            
            if (Course != null) {
                return Ok(Course);
            }

            return NotFound();
        }
        
        return BadRequest();
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllCourses()
    {
        if (ModelState.IsValid)
        {
            var Courses = await _context.Courses.ToListAsync();
            return Ok(Courses);
        }
        return BadRequest();
    }


    [HttpPatch]
    public async Task<IActionResult> UpdateCoruse()
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteCourse(int Id)
    {
        if (ModelState.IsValid)
        {
            var CourseEntity = await _context.Courses.FirstOrDefaultAsync(x => x.Id == Id);

            if (CourseEntity != null)
            {
                _context.Courses.Remove(CourseEntity);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return NotFound();
        }

        return BadRequest();
    }
}
