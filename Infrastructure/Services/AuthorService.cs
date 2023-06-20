using Domain.Dtos.Author;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class AuthorService
{
    private readonly DataContext _context;

    public AuthorService(DataContext context)
    {
        _context = context;
    }

    public GetAuthor AddAuthor(AddAuthor author)
    {
        var model = new Author()
        {
            FirstName = author.FirstName,
            LastName = author.LastName,
            State = author.State,
            Address = author.Address,
            City = author.City,
            Phone = author.Phone,
            SSN = author.SSN,
            Zip = author.Zip
        };
        _context.Authors.Add(model);
        _context.SaveChanges();
        author.Id = model.Id;
        return new GetAuthor()
        {
            Id = model.Id,
            Address = model.Address,
            City = model.City,
            Phone = model.Phone,
            SSN = model.SSN,
            State = model.State,
            LastName = model.LastName,
            FirstName = model.FirstName,
            Zip = model.Zip
        };
    }

    public GetAuthor UpdateAuthor(AddAuthor author)
    {
        var find = _context.Authors.Find(author.Id);
        if (find == null) return new GetAuthor();
        find.Address = author.Address;
        find.City = author.City;
        find.Phone = author.Phone;
        find.SSN = author.SSN;
        find.State = author.State;
        find.LastName = author.LastName;
        find.FirstName = author.FirstName;
        find.Zip = author.Zip;
        _context.SaveChanges();
        return new GetAuthor()
        {
            Id = find.Id,
            FirstName = find.FirstName,
            LastName = find.LastName,
            Address = find.Address,
            City = find.City,
            Phone = find.Phone,
            SSN = find.SSN,
            State = find.State,
            Zip = find.Zip
        };
    }

    public bool DeleteAuthor(int id)
    {
        var find = _context.Authors.Find(id);
        if (find != null)
        {
            _context.Authors.Remove(find);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public GetAuthor GetAuthorById(int id)
    {
        var find = _context.Authors.Find(id);
        if (find != null)
        {
            return new GetAuthor()
            {
                Id = find.Id,
                FirstName = find.FirstName,
                LastName = find.LastName,
                Address = find.Address,
                City = find.City,
                State = find.State,
                SSN = find.SSN,
                Phone = find.Phone,
                Zip = find.Zip
            };
        }
        return new GetAuthor();
    }
    public List<GetAuthor> GetAuthors(int id)
    {
        var result = _context.Authors.Select(e => new GetAuthor()
        {
            Id = e.Id,
            FirstName = e.FirstName,
            LastName = e.LastName,
            Address = e.Address,
            City = e.City,
            Phone = e.Phone,
            SSN = e.SSN,
            State = e.State,
            Zip = e.Zip
        }).ToList();
        return result;
    }
}