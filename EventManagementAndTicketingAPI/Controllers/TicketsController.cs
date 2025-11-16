using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventManagementAndTicketingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        public required List<Ticket> _tickets;
        public required JwtSecurityToken jwt;
        private static int userId;
        public required List<Event> _musicevents;
        [HttpPost]
        public IActionResult BookTicketsForEvents(Ticket ticket)
        {
            var Idclaim = jwt.Claims.First(c => c.Type == "nameid").Value;
            if (ticket == null)
            {
                return BadRequest("Ticket must not be null");
            }
            if (Convert.ToString(ticket.EventID) == null ||
                (string.IsNullOrEmpty(ticket.Status)))
            {
                return Unauthorized("Either EventID, or Ticket status must not be null");
            }
            if (ticket.Status != "Booked")
            {
                return Unauthorized("User's ticket status must be Booked");
            }
            bool existedticket = true;
            for (int i=0;i<_musicevents.Count; i++)
            {
                if (_musicevents[i].id == ticket.EventID)
                {
                    existedticket = false;
                    break;
                }
            }
            if (existedticket == true)
            {
                return Unauthorized("This registered event id does not exist in music events' ids");
            }
            ticket.UserID = Convert.ToInt32(Idclaim);
            _tickets.Add(ticket);
            return Ok(new { Message = "Succesfully Booked Ticket",
                Data = "EventID: "+ticket.EventID+
                " UserID: " + ticket.UserID+
                " Status: " + ticket.Status
            });
        }
        [HttpGet("{userId}")]
        [Authorize]
        public IActionResult GetUsersBookedTickets()
        {
            string usersbookedtickets="";
            var Idclaim = jwt.Claims.First(c => c.Type == "nameid").Value;
            if (jwt == null)
            {
                return BadRequest("Null JWT token not allowed");
            }
            for(int i = 0; i< _tickets.Count; i++)
            {
                if (_tickets[i].UserID==Convert.ToInt32(Idclaim))
                {
                    usersbookedtickets += "EventID: "+ _tickets[i].EventID+"\n"+
                    "UserID: "+_tickets[i].UserID + "\n"+
                    "Status: "+_tickets[i].Status + "\n";
                }
            }
            return Ok(new
            {
                Message = "Successfully retrieved all Users' booked tickets",
                Data = usersbookedtickets
                
            });
        }
        [HttpPut]
        public IActionResult AdjustBookedTicket(Ticket ticket)
        {
            var claims = jwt.Claims.First(c => c.Type == "role").Value;
            var Idclaim = jwt.Claims.First(c => c.Type == "nameid").Value;
            if (ticket == null)
            {
                return BadRequest("Ticket must not be null");
            }
            if (string.IsNullOrEmpty(ticket.Status))
            {
                return Unauthorized("Ticket Status must not be null");
            }
            if (ticket.Status != "Booked"&& ticket.Status != "Cancelled")
            {
                return Unauthorized("User's ticket status must be Booked or Cancelled");
            }
            if (claims !="Admin")
            {
                return Unauthorized("User's Role must be Admin");
            }
            string updatedbooktickets = "";
            for (int i=0; i< _tickets.Count;i++)
            {
                if (_tickets[i].UserID==Convert.ToInt32(Idclaim)
                    && _tickets[i].EventID == ticket.EventID)
                {
                    _tickets[i].Status = ticket.Status;
                    updatedbooktickets += "EventID: " + _tickets[i].EventID +
                    " UserID: " + _tickets[i].UserID +
                    " Status: " + _tickets[i].Status;
                }
            }
            return Ok(new
            {
                Message = "Successfully updated booked ticket status",
                Data = updatedbooktickets
            });
        }
        public List<Ticket> Getlisttickets()
        {
            return _tickets;
        }
    }
}
