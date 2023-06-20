using Domain.Dtos.Publisher;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class PublisherService
{
    private readonly DataContext _context;

    public PublisherService(DataContext context)
    {
        _context = context;
    }
    public GetPublisher AddPublisher(AddPublisher editor)
    {
        var model = new Publisher()
        {
            Address = editor.Address,
            City = editor.City,
            State = editor.State,
            Name = editor.Name
        };
        _context.Publishers.Add(model);
        _context.SaveChanges();
        return new GetPublisher()
        {
            Address = model.Address,
            City = model.City,
            State = model.State,
            Name = model.Name,
            Id = model.Id
        };
    }
        public GetPublisher UpdatePublisher(AddPublisher editor)
    {
        var find = _context.Publishers.Find(editor.Id);
        if (find == null) return new GetPublisher();
        find.Address = editor.Address;
        find.City = editor.City;
        find.State = editor.State;
        find.Name = editor.Name;
        _context.SaveChanges();
        return new GetPublisher()
        {
            Id = editor.Id,
            Address = editor.Address,
            City = editor.City,
            State = editor.State,
            Name = editor.Name
        };
    }

    public bool DeletePublisher(int id)
    {
        var find = _context.Publishers.Find(id);
        if (find != null)
        {
            _context.Publishers.Remove(find);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public GetPublisher GetPublisherById(int isbn)
    {
        var find = _context.Publishers.Find(isbn);
        if (find != null)
        {
            return new GetPublisher()
            {
                Id = find.Id,
                Address = find.Address,
                City = find.City,
                State = find.State,
                Name = find.Name
            };
        }
        return new GetPublisher();
    }
    public List<GetPublisher> GetPublishers()
    {
        var result = _context.Publishers.Select(e => new GetPublisher()
        {
            Id = e.Id,
            Address = e.Address,
            City = e.City,
            State = e.State,
            Name = e.Name
        }).ToList();
        return result;
    }
}