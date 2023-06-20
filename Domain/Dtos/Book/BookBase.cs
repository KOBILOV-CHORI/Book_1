namespace Domain.Dtos.Book;

public class BookBase
{
    public int ISBN { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public int PublisherId { get; set; }
    public int Price { get; set; }
    public int Advance { get; set; }
    public int YTDSales { get; set; }
    public DateTime PubDate { get; set; }
}