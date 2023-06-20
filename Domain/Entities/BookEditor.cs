using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class BookEditor
{
    [Key]
    public int EditorId { get; set; }
    public int BookISBN { get; set; }
    public Editor Editor { get; set; }
    public Book Book { get; set; }
}