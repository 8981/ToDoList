using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Infrastructure
{
    public class ToDoContext  : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            :base(options)
            {

            }

            public DbSet<ToDo>? ToDoList {get; set;}
    }
}