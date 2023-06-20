using Domain.Dtos.Author;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController
{
    private readonly AuthorService _service;

    public AuthorController(AuthorService service)
    {
        _service = service;
    }

    [HttpPost("AddAuthor")]
    public GetAuthor AddAuthor(AddAuthor author)
    {
        return _service.AddAuthor(author);
    }

    [HttpPut("UpdateAuthor")]
    public GetAuthor UpdateAuthor(AddAuthor author)
    {
        return _service.UpdateAuthor(author);
    }

    [HttpDelete("DeleteAuthor")]
    public bool DeleteAuthor(int authorId)
    {
        return _service.DeleteAuthor(authorId);
    }

    [HttpGet("GetAuthorById")]
    public GetAuthor GetAuthorById(int authorId)
    {
        return _service.GetAuthorById(authorId);
    }

    [HttpGet("GetAuthors")]
    public List<GetAuthor> GetAuthors()
    {
        return _service.GetAuthors();
    }
}