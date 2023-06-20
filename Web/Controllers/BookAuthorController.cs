using Domain.Dtos.BookAuthor;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class BookAuthorController
{
    private readonly BookAuthorService _service;

    public BookAuthorController(BookAuthorService service)
    {
        _service = service;
    }

    [HttpPost("AddBookAuthor")]
    public GetBookAuthor AddBookAuthor(AddBookAuthor book)
    {
        return _service.AddBookAuthor(book);
    }

    [HttpPut("UpdateBookAuthor")]
    public GetBookAuthor UpdateBookAuthor(AddBookAuthor book)
    {
        return _service.UpdateBookAuthor(book);
    }

    [HttpDelete("DeleteBookAuthor")]
    public bool DeleteBookAuthor(int bookId)
    {
        return _service.DeleteBookAuthor(bookId);
    }

    [HttpGet("GetBookAuthorById")]
    public GetBookAuthor GetBookAuthorById(int isbn)
    {
        return _service.GetBookAuthorById(isbn);
    }

    [HttpGet("GetBookAuthors")]
    public List<GetBookAuthor> GetBookAuthors()
    {
        return _service.GetBookAuthors();
    }
}