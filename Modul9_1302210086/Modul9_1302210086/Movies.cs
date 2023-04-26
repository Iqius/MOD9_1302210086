using System.Numerics;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Diagnostics;

namespace Modul9_1302210086
{
    [Route("api/[controller]")]
    [ApiController]
    public class Movies : Controller
    {
        public static List<Movie> mvi = new List<Movie>
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", new List<string>(){"Tim Robbins", "Morgan Freeman", "Bob Gunton", "William Sadler" }, "wo imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
            new Movie ("The Godfather (1972", "Francis Ford Coppola ", new List<string>() {"Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"}, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie ( "The Dark Knight" , "Christopher Nolan ", new List<string>() {"Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return mvi;
        }
        [HttpGet("{id}")]
        public Movie get(int id)
        {
            return mvi[id];
        }
        [HttpPost]
        public IActionResult Post([FromBody] Movie newMvi)
        {
            mvi.Add(newMvi);
            return Ok();
        }

        [HttpDelete("{id")]
        public IActionResult Delete(int id)
        {
            if (id >= mvi.Count)
            {
                return NotFound();
            }

            mvi.RemoveAt(id);
            return Ok();
        }

    }

}
