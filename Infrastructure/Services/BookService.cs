using Domain.Dtos.Book;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class BookService
{
    private readonly DataContext _context;

    public BookService(DataContext context)
    {
        _context = context;
    }

    public GetBook AddBook(AddBook book)
    {
        var model = new Book()
        {   
            Title = book.Title,
            Type = book.Type,
            PublisherId = book.PublisherId,
            Price = book.Price,
            Advance = book.Advance,
            YTDSales = book.YTDSales,
            PubDate = book.PubDate
        };
        _context.Books.Add(model);
        _context.SaveChanges();
        book.ISBN = model.ISBN;
        return new GetBook()
        {
            ISBN = model.ISBN,
            Advance = model.Advance,
            YTDSales = model.YTDSales,
            Price = model.Price,
            Title = model.Title,
            Type = model.Type,
            PublisherId = model.PublisherId,
            PubDate = model.PubDate
        };
    }
        public GetBook UpdateBook(AddBook book)
    {
        var find = _context.Books.Find(book.ISBN);
        if (find == null) return new GetBook();
        find.Title = book.Title;
        find.Type = book.Type;
        find.PublisherId = book.PublisherId;
        find.YTDSales = book.YTDSales; 
        find.Price = book.Price;
        find.PubDate = book.PubDate;
        find.Advance = book.Advance;
        _context.SaveChanges();
        return new GetBook()
        {
            ISBN = find.ISBN,
            Title = find.Title,
            Type = find.Type,
            PublisherId = find.PublisherId,
            YTDSales = find.YTDSales,
            Price = find.Price,
            PubDate = find.PubDate,
            Advance = find.Advance,
        };
    }

    public bool DeleteBook(int id)
    {
        var find = _context.Books.Find(id);
        if (find != null)
        {
            _context.Books.Remove(find);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public GetBook GetBookById(int isbn)
    {
        var find = _context.Books.Find(isbn);
        if (find != null)
        {
            return new GetBook()
            {
                ISBN = find.ISBN,
                Title = find.Title,
                Type = find.Type,
                PublisherId = find.PublisherId,
                YTDSales = find.YTDSales,
                Price = find.Price,
                PubDate = find.PubDate,
                Advance = find.Advance,
            };
        }
        return new GetBook();
    }
    public List<GetBook> GetBooks()
    {
        var result = _context.Books.Select(e => new GetBook()
        {
            ISBN = e.ISBN,
            Title = e.Title,
            Type = e.Type,
            PublisherId = e.PublisherId,
            YTDSales = e.YTDSales,
            Price = e.Price,
            PubDate = e.PubDate,
            Advance = e.Advance,
        }).ToList();
        return result;
    }
}