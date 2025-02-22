using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    [Route("api/[Controller]")]

    [ApiController]
    public class BooksController: ControllerBase
    {
        private Book[] _books = new Book[]{
            new Book {Id=1, Author="Author1", Title="Its a anice book title 1"},
            new Book {Id=2, Author="Author2", Title="Just another title 2"},
            new Book {Id=3, Author="Author3", Title="Super-diper book title 3"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
