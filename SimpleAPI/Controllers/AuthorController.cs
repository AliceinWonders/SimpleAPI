using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Models;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class AuthorController : ControllerBase
    {
        [HttpGet("/author")]
        public ActionResult<BooksWithAuthor> Get()
        {
            ICollection<string> books = new List<string>();
            string book1 = "War and piece";
            string book2 = "Anna Karenina";
            books.Add(book1);
            books.Add(book2);
            BooksWithAuthor booksEntity = new BooksWithAuthor(books,"Lev Tolstoy");
            return Ok(booksEntity); 
            
        }
    }
}