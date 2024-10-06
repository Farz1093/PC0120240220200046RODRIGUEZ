using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PC0120240220200046RODRIGUEZ.DOMAIN.Core.Interfaces;
using PC0120240220200046RODRIGUEZ.DOMAIN.Infrastructure.Repositories;

namespace PC0120240220200046RODRIGUEZ.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly IAttendeesRepository _attendeesRepository;
        public AttendeesController(IAttendeesRepository attendeesRepository)
        {
            _attendeesRepository = attendeesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAttendes()
        {
            var attendees = await _attendeesRepository.GetAttendes();
            return Ok(attendees);
        }





    }
}
