using Microsoft.AspNetCore.Mvc;
using BooksApi.Services.Interfaces;
using BooksApi.Models;

namespace BooksApi.Controllers
{
      [ApiController]
      [Route("api/[controller]")]
      public class BooksController : ControllerBase
      {
            private readonly IBooksService _booksService;
            public BooksController(IBooksService booksService)
            {
                  _booksService = booksService;
            }

            [HttpGet]
            public IActionResult GetAll()
            {
                  return Ok(_booksService.GetAll());
            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                  var book = _booksService.GetById(id);
                  if (book == null)
                  {
                        return NotFound();
                  }
                  return Ok(book);
            }
            [HttpPost]
            public IActionResult Create([FromBody] Book book)
            {
                  if (book == null)
                  {
                        return BadRequest();
                  }

                  var id = _booksService.Create(book);

                  return CreatedAtAction(nameof(GetById), new { id }, book);
            }
      }

}