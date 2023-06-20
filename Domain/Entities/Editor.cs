using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Editor
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
    public string EditorPosition { get; set; }
    public decimal Salary { get; set; }
    public List<BookEditor> BookEditors { get; set; }
}
