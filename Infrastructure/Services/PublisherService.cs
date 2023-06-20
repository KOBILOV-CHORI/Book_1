using Infrastructure.Data;

namespace Infrastructure.Services;

public class PublisherService
{
    private readonly DataContext _context;

    public PublisherService(DataContext context)
    {
        _context = context;
    }
}