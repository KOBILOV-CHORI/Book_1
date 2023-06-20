namespace Domain.Dtos.Book;

public class GetFullInfo
{
    public int ISBN { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public int Price { get; set; }
    public int Advance { get; set; }
    public int YTDSales { get; set; }
    public int PublisherId { get; set; }
    public string PublisherName { get; set; }
    public int AuthorId { get; set; }
    public int SSN { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public DateTime PubDate { get; set; }
}