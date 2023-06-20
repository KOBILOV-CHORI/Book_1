using Domain.Dtos.BookEditor;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class BookEditorService
{
    private readonly DataContext _context;

    public BookEditorService(DataContext context)
    {
        _context = context;
    }
    public GetBookEditor AddBookEditor(AddBookEditor book)
    {
        var model = new BookEditor()
        {   
            BookISBN = book.BookISBN,
            EditorId = book.EditorId
        };
        _context.BookEditors.Add(model);
        _context.SaveChanges();
        return new GetBookEditor()
        {
            BookISBN = model.BookISBN,
            EditorId = model.EditorId
        };
    }
        public GetBookEditor UpdateBookEditor(AddBookEditor book)
    {
        var find = _context.BookEditors.Find(book.BookISBN);
        if (find == null) return new GetBookEditor();
        _context.SaveChanges();
        return new GetBookEditor()
        {
            EditorId = find.EditorId,
            BookISBN = find.BookISBN
        };
    }

    public bool DeleteBookEditor(int id)
    {
        var find = _context.BookEditors.Find(id);
        if (find != null)
        {
            _context.BookEditors.Remove(find);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public GetBookEditor GetBookEditorById(int isbn)
    {
        var find = _context.BookEditors.Find(isbn);
        if (find != null)
        {
            return new GetBookEditor()
            {
                EditorId = find.EditorId,
                BookISBN = find.BookISBN
            };
        }
        return new GetBookEditor();
    }
    public List<GetBookEditor> GetBookEditors()
    {
        var result = _context.BookEditors.Select(e => new GetBookEditor()
        {
            EditorId = e.EditorId,
            BookISBN = e.BookISBN,
        }).ToList();
        return result;
    }
}