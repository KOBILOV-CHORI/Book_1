using Infrastructure.Data;

namespace Infrastructure.Services;

public class BookEditorService
{
    private readonly DataContext _context;

    public BookEditorService(DataContext context)
    {
        _context = context;
    }
}