using Domain.Dtos.BookAuthor;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class BookAuthorService
{
    private readonly DataContext _context;

    public BookAuthorService(DataContext context)
    {
        _context = context;
    }
    public GetBookAuthor AddBookAuthor(AddBookAuthor book)
    {
        var model = new BookAuthor()
        {   
            AuthorId = book.AuthorId,
            AuthorOrder = book.AuthorOrder,
            RoyaltyShare = book.RoyaltyShare
        };
        _context.BookAuthors.Add(model);
        _context.SaveChanges();
        return new GetBookAuthor()
        {
            AuthorId = model.AuthorId,
            AuthorOrder = model.AuthorOrder,
            RoyaltyShare = model.RoyaltyShare,
            BookISBN = model.BookISBN
        };
    }
        public GetBookAuthor UpdateBookAuthor(AddBookAuthor book)
    {
        var find = _context.BookAuthors.Find(book.BookISBN);
        if (find == null) return new GetBookAuthor();
        find.RoyaltyShare = book.RoyaltyShare;
        _context.SaveChanges();
        return new GetBookAuthor()
        {
            AuthorId = book.AuthorId,
            AuthorOrder = book.AuthorOrder,
            RoyaltyShare = book.RoyaltyShare,
            BookISBN = book.BookISBN
        };
    }

    public bool DeleteBookAuthor(int authorId)
    {
        var find = _context.BookAuthors.Find(authorId);
        if (find != null)
        {
            _context.BookAuthors.Remove(find);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public GetBookAuthor GetBookAuthorById(int isbn)
    {
        var find = _context.BookAuthors.Find(isbn);
        if (find != null)
        {
            return new GetBookAuthor()
            {
                AuthorId = find.AuthorId,
                AuthorOrder = find.AuthorOrder,
                RoyaltyShare = find.RoyaltyShare,
                BookISBN = find.BookISBN
            };
        }
        return new GetBookAuthor();
    }
    public List<GetBookAuthor> GetBookAuthors()
    {
        var result = _context.BookAuthors.Select(e => new GetBookAuthor()
        {
            AuthorId = e.AuthorId,
            AuthorOrder = e.AuthorOrder,
            RoyaltyShare = e.RoyaltyShare,
            BookISBN = e.BookISBN
        }).ToList();
        return result;
    }
}