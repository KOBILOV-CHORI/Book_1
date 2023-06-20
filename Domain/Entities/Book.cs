using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace Domain.Entities;

public class Book
{
    [Key]
    public int ISBN { get; set; }
    [MaxLength(100)]
    public string Title { get; set; }
    [MaxLength(100)]
    public string Type { get; set; }
    public int PublisherId { get; set; }
    public int Price { get; set; }
    public int Advance { get; set; }
    public int YTDSales { get; set; }
    public DateTime PubDate { get; set; }
    public List<BookAuthor> BookAuthors { get; set; }
    public Publisher Publisher { get; set; }
    public List<BookEditor> BookEditors { get; set; }
}