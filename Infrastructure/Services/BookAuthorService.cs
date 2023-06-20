using Infrastructure.Data;

namespace Infrastructure.Services;

public class BookAuthorService
{
    private readonly DataContext _context;

    public BookAuthorService(DataContext context)
    {
        _context = context;
    }
}