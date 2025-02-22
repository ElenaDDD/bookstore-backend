using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    [Route("api/[Controller]")]

    [ApiController]
    public class BooksController: ControllerBase
    {
        private Book[] _books = new Book[]{
            new Book {Id=1, Author="1", Title="1"},
            new Book {Id=2, Author="2", Title="2"},
            new Book {Id=3, Author="3", Title="3"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
