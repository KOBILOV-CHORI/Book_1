using Domain.Dtos.BookEditor;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class BookEditorController
{
    private readonly BookEditorService _service;

    public BookEditorController(BookEditorService service)
    {
        _service = service;
    }

    [HttpPost("AddBookEditor")]
    public GetBookEditor AddBookEditor(AddBookEditor book)
    {
        return _service.AddBookEditor(book);
    }

    [HttpPut("UpdateBookEditor")]
    public GetBookEditor UpdateBookEditor(AddBookEditor book)
    {
        return _service.UpdateBookEditor(book);
    }

    [HttpDelete("DeleteBookEditor")]
    public bool DeleteBookEditor(int bookId)
    {
        return _service.DeleteBookEditor(bookId);
    }

    [HttpGet("GetBookEditorById")]
    public GetBookEditor GetBookEditorById(int isbn)
    {
        return _service.GetBookEditorById(isbn);
    }

    [HttpGet("GetBookEditors")]
    public List<GetBookEditor> GetBookEditors()
    {
        return _service.GetBookEditors();
    }
}