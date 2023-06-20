using Infrastructure.Data;

namespace Infrastructure.Services;

public class EditorService
{
    private readonly DataContext _context;

    public EditorService(DataContext context)
    {
        _context = context;
    }
}