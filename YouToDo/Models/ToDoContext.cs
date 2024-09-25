using Microsoft.EntityFrameworkCore;

namespace YouToDo.Models
{
    public partial class ToDoContext:DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
