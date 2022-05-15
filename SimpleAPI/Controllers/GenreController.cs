using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Models;

namespace SimpleAPI.Controllers
{
    [ApiController]
        [Route("/")]
        public class GenreController : ControllerBase
        {
             [HttpGet("/genre")]
             public ActionResult<BookWithGenres> Get()
             {
                 ICollection<string> books = new List<string>();
                 string book1 = ("War and piece");
                 string book2 = ("Anna Karenina");
                 string book3 = ("Resurrection");
                 books.Add(book1);
                 books.Add(book2);
                 books.Add(book3);
                 BookWithGenres booksEntity = new BookWithGenres(books,"Prose");
                 return Ok(booksEntity); 
             }
        }
}