using Domain.Dtos.Editor;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class EditorController
{
    private readonly EditorService _service;

    public EditorController(EditorService service)
    {
        _service = service;
    }

    [HttpPost("AddEditor")]
    public GetEditor AddEditor(AddEditor book)
    {
        return _service.AddEditor(book);
    }

    [HttpPut("UpdateEditor")]
    public GetEditor UpdateEditor(AddEditor book)
    {
        return _service.UpdateEditor(book);
    }

    [HttpDelete("DeleteEditor")]
    public bool DeleteEditor(int bookId)
    {
        return _service.DeleteEditor(bookId);
    }

    [HttpGet("GetEditorById")]
    public GetEditor GetEditorById(int isbn)
    {
        return _service.GetEditorById(isbn);
    }

    [HttpGet("GetEditors")]
    public List<GetEditor> GetEditors()
    {
        return _service.GetEditors();
    }
}