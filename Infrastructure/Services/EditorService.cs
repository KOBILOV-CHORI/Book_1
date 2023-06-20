using Domain.Dtos.Editor;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class EditorService
{
    private readonly DataContext _context;

    public EditorService(DataContext context)
    {
        _context = context;
    }
    public GetEditor AddEditor(AddEditor editor)
    {
        var model = new Editor()
        {   
            FirstName = editor.FirstName,
            LastName = editor.LastName,
            SSN = editor.SSN,
            Phone = editor.Phone,
            Salary = editor.Salary,
            EditorPosition = editor.EditorPosition
        };
        _context.Editors.Add(model);
        _context.SaveChanges();
        return new GetEditor()
        {
            Id = editor.Id,
            FirstName = model.FirstName,
            LastName = model.LastName,
            SSN = model.SSN,
            Phone = model.Phone,
            Salary = model.Salary,
            EditorPosition = model.EditorPosition
        };
    }
        public GetEditor UpdateEditor(AddEditor editor)
    {
        var find = _context.Editors.Find(editor.Id);
        if (find == null) return new GetEditor();
        find.FirstName = editor.FirstName;
        find.LastName = editor.LastName;
        find.SSN = editor.SSN;
        find.Phone = editor.Phone;
        find.Salary = editor.Salary;
        find.EditorPosition = editor.EditorPosition;
        _context.SaveChanges();
        return new GetEditor()
        {
            Id = editor.Id,
            FirstName = editor.FirstName,
            LastName = editor.LastName,
            SSN = editor.SSN,
            Phone = editor.Phone,
            Salary = editor.Salary,
            EditorPosition = editor.EditorPosition
        };
    }

    public bool DeleteEditor(int id)
    {
        var find = _context.Editors.Find(id);
        if (find != null)
        {
            _context.Editors.Remove(find);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public GetEditor GetEditorById(int isbn)
    {
        var find = _context.Editors.Find(isbn);
        if (find != null)
        {
            return new GetEditor()
            {
                Id = find.Id,
                FirstName = find.FirstName,
                LastName = find.LastName,
                SSN = find.SSN,
                Phone = find.Phone,
                Salary = find.Salary,
                EditorPosition = find.EditorPosition
            };
        }
        return new GetEditor();
    }
    public List<GetEditor> GetEditors()
    {
        var result = _context.Editors.Select(e => new GetEditor()
        {
            Id = e.Id,
            FirstName = e.FirstName,
            LastName = e.LastName,
            SSN = e.SSN,
            Phone = e.Phone,
            Salary = e.Salary,
            EditorPosition = e.EditorPosition
        }).ToList();
        return result;
    }
}