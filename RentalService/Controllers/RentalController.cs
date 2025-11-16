using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace RentalService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalController : Controller
    {
        //list of all rentals
        private static List<Rental> RentalsList = new List<Rental>();

        //POST /api/rentals: Rent an album by providing user ID and album ID.
        [HttpPost]
        public ActionResult RentAlbum(Rental rental)
        {
            //check if album is already rented
            var isRented = RentalsList.Any(r => r.AlbumId == rental.AlbumId && r.ReturnDate == null);
            if (isRented)
            {
                return BadRequest("Album is currently not available for rent!");
            }
            RentalsList.Add(rental);
            return Ok("Album rented successfully");
        }

        //POST /api/rentals/{id}/return: Return a rented album.
        [HttpPost("{albumId}/return")]
        public ActionResult ReturnAlbum(int albumId)
        {
            var rental = RentalsList.FirstOrDefault(r => r.AlbumId == albumId);
            if (rental == null)
            {
                return NotFound("Rental record not found!");
            }
            rental.ReturnDate = DateTime.Now;
            return Ok("Album returned successfully");
        }


        //GET /api/rentals: List all active rentals.
        [HttpGet("Active")]
        public ActionResult<List<Rental>> GetAllActiveRentals()
        {
            var activeRental = RentalsList.Where(r => r.ReturnDate == null).ToList();
            return Ok(activeRental);
        }

        //Delete album rentals when album gets deleted
        [HttpDelete("{albumId}")]
        public ActionResult DeleteRental(int albumId)
        {
            var rental = RentalsList.FirstOrDefault(a => a.AlbumId == albumId);
            if (rental == null)
            {
                return NotFound("rental not Found");
            }
            RentalsList.Remove(rental);
            return Ok("rental was removed successfully");
        }


    }
}
