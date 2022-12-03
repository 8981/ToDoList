using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.API;
public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {
        
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}