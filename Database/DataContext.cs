using Microsoft.EntityFrameworkCore;

namespace ReactApp.Database
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}