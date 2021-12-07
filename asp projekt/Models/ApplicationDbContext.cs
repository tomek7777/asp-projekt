using Microsoft.EntityFrameworkCore;

namespace Lab_5_2.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : 
            base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BlogItem> BlogItems { get; set; }

        public DbSet<Issue> Issues { get; set; }

    }
}