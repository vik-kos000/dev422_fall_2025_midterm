using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace EventManagementAndTicketingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public required List<Event> _musicevents;
        public required JwtSecurityToken jwt;
        [HttpPost]
        public IActionResult AddNewMusicEvent(Event musicevent)
        {
            var claims = jwt.Claims.First(c => c.Type == "role").Value;
            if (musicevent == null)
            {
                return BadRequest("Event must not be null");
            }
            if (string.IsNullOrEmpty(musicevent.Name)||
                string.IsNullOrEmpty(musicevent.Venue)||
                string.IsNullOrEmpty(musicevent.Genre))
            {
                return Unauthorized("Either Name, Venue, or Genre must not be null");
            }
            if (claims != "Admin" && claims != "Event Manager")
            {
                return Unauthorized("User's role must be Admin or Event Manager to add new music event");
            }
            musicevent.Date = DateTime.Now;
            musicevent.id += _musicevents.Count;
            _musicevents.Add(musicevent);
            return Ok(new { Message = "Successfully added new music event",
                Data = "Name: "+musicevent.Name+
                 " Date: " + musicevent.Date +
                  " Venue: " + musicevent.Venue +
                   " Genre: " + musicevent.Genre +
                    " Available Tickets: " + musicevent.AvailableTickets
            });
        }
        [HttpGet]
        [Authorize]
        public IActionResult ListAllUpcomingEvents()
        {
            string allupcomingevents="";
            if (jwt==null)
            {
                return BadRequest("Null JWT token not allowed");
            }
            for (int i = 0; i < _musicevents.Count; i++)
            {
                allupcomingevents += "\nEventID: " + _musicevents[i].id + "\n" +
                "Name: " + _musicevents[i].Name + "\n" +
                "Date: " + _musicevents[i].Date + "\n" +
                "Venue: " + _musicevents[i].Venue + "\n" +
                "Genre: " + _musicevents[i].Genre + "\n" +
                "Available Tickets: " + _musicevents[i].AvailableTickets;
            }
            return Ok(new
            {
                Message = "Successfully listed all upcoming events",
                Data = allupcomingevents
            });
        }
        public List<Event> Getlistevent()
        {
            return _musicevents;
        }
    }
}
