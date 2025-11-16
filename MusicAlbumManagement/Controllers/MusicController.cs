using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MusicAlbumManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : Controller
    {
        //save/store albums - list
        private static List<Album> albums = new List<Album>();

        //POST /api/music: Add a new music album.
        [HttpPost]
        public ActionResult AddAlbum (Album album)
        {
            album.Id = albums.Count + 1;
            albums.Add(album);
            return Ok("Album was added successfully");
        }

        //find an album based on id
        [HttpGet("{id}")]
        public ActionResult<Album> GetAlbumById(int id)
        {
            var album = albums.FirstOrDefault(m => m.Id == id);
            if (album == null) return NotFound("Movie not found");
            return Ok(album);
        }


        //PUT update album for avaliability
        [HttpPut("{id}")]
        public ActionResult UpdateAlbum(int id, Album updatedAlbum)
        {
            var album = albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                return NotFound("Album not found");
            }

            // update properties
            album.Available = updatedAlbum.Available;

            return Ok("Album updated successfully");
        }


        //GET /api/music: List all available music albums.
        [HttpGet]
        public ActionResult<List<Album>> GetAlbums()
        {
            return Ok(albums);
        }

        //DELETE /api/music/{id}: Delete a music album by its ID.
        [HttpDelete("{id}")]
        public ActionResult DeleteAlbum(int id)
        {
            var album = albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                return NotFound("Album not Found");
            }
            albums.Remove(album);
            return Ok("Album was removed successfully");
        }
    }
}
        


    

