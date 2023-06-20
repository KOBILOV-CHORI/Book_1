namespace Domain.Dtos.BookAuthor;

public class BookAuthorBase
{
    public int AuthorId { get; set; }
    public int BookISBN { get; set; }
    public int AuthorOrder { get; set; }
    public decimal RoyaltyShare { get; set; }
}