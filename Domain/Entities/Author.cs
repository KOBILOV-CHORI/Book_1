using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Author
{
    public int Id { get; set; }
    [Key]
    public int SSN { get; set; }
    [MaxLength(100)]
    public string FirstName { get; set; }
    [MaxLength(100)]
    public string LastName { get; set; }
    [MaxLength(100)]
    public string Phone { get; set; }
    [MaxLength(100)]
    public string Address { get; set; }
    [MaxLength(100)]
    public string City { get; set; }
    [MaxLength(100)]
    public string State { get; set; }
    [MaxLength(150)]
    public string Zip { get; set; }
    public List<BookAuthor> BookAuthors { get; set; }
}