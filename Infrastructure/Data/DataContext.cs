using Domain.Dtos.BookAuthor;
using Domain.Dtos.BookEditor;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Editor> Editors { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<BookEditor> BookEditors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
}