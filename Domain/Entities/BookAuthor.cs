using System.Security.AccessControl;

namespace Domain.Entities;

public class BookAuthor
{
    public int AuthorId { get; set; }
    public int BookISBN { get; set; }
    public int AuthorOrder { get; set; }
    public decimal RoyaltyShare { get; set; }
    public Author Author { get; set; }
    public Book Book { get; set; }  
}