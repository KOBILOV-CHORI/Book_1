using Domain.Dtos.Publisher;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class PublisherController
{
    private readonly PublisherService _service;

    public PublisherController(PublisherService service)
    {
        _service = service;
    }

    [HttpPost("AddPublisher")]
    public GetPublisher AddPublisher(AddPublisher book)
    {
        return _service.AddPublisher(book);
    }

    [HttpPut("UpdatePublisher")]
    public GetPublisher UpdatePublisher(AddPublisher book)
    {
        return _service.UpdatePublisher(book);
    }

    [HttpDelete("DeletePublisher")]
    public bool DeletePublisher(int bookId)
    {
        return _service.DeletePublisher(bookId);
    }

    [HttpGet("GetPublisherById")]
    public GetPublisher GetPublisherById(int isbn)
    {
        return _service.GetPublisherById(isbn);
    }

    [HttpGet("GetPublishers")]
    public List<GetPublisher> GetPublishers()
    {
        return _service.GetPublishers();
    }
}