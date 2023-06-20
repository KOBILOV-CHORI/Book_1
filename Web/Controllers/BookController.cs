using Domain.Dtos.Book;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController
{
    private readonly BookService _service;

    public BookController(BookService service)
    {
        _service = service;
    }

    [HttpPost("AddBook")]
    public GetBook AddBook(AddBook book)
    {
        return _service.AddBook(book);
    }

    [HttpPut("UpdateBook")]
    public GetBook UpdateBook(AddBook book)
    {
        return _service.UpdateBook(book);
    }

    [HttpDelete("DeleteBook")]
    public bool DeleteBook(int bookId)
    {
        return _service.DeleteBook(bookId);
    }

    [HttpGet("GetBookById")]
    public GetBook GetBookById(int isbn)
    {
        return _service.GetBookById(isbn);
    }

    [HttpGet("GetBooks")]
    public List<GetBook> GetBooks()
    {
        return _service.GetBooks();
    }
}