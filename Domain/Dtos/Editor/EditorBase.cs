namespace Domain.Dtos.Editor;

public class EditorBase
{
    public int Id { get; set; }
    public int SSN { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string EditorPosition { get; set; }
    public decimal Salary { get; set; }
}