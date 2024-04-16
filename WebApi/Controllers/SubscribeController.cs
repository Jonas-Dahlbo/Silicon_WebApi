using Infrastructure.Context;
using Infrastructure.Dtos;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context;

    [HttpPost]
    public async Task<IActionResult> Subscribe(SubscriberDto dto)
    {
        if (ModelState.IsValid)
        {
            if (! await _context.Subscribers.AnyAsync(x => x.Email == dto.Email))
            {
                _context.Subscribers.Add(new SubscriberEntity
                {
                    Email = dto.Email,
                    DailyNewsletter = dto.DailyNewsletter,
                    AdvertisingUpdates = dto.AdvertisingUpdates,
                    WeekInReviews = dto.WeekInReviews,
                    EventUppdates = dto.EventUppdates,
                    StartupsWeekly = dto.StartupsWeekly,
                    Podcasts = dto.Podcasts,
                });

                return Created();
            }
            else
            {
                return Conflict();
            }
        }

        return BadRequest();


    }

    [HttpDelete]
    public async Task<IActionResult> Unsubscribe()
    {
        return Ok();
    }
}
