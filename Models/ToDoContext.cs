using ExampleToDoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampleToDoApi.Models;

public class ToDoContext : DbContext
{
    public ToDoContext(DbContextOptions<ToDoContext> options)
        : base(options)
    {
    }

    public DbSet<ToDoItem> TodoItems { get; set; } = null!;
}
