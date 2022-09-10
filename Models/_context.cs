using Microsoft.EntityFrameworkCore;
namespace ProductivityWebPage.Model
{
    public class ScheduleContext : DbContext
    {
        public DbSet<Project> Projects {get; set;}
        public DbSet <TodoItem> TodoItems {get; set;}
        public DbSet <TimeTable> TimeTable {get; set;}
        public string DbPath { get; }
        

        public ScheduleContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Schedule.db");
            // path : /home/neko/.local/share/Schedule.db
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}