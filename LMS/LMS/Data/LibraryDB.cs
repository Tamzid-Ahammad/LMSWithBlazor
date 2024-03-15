using LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.Data
{
    public class LibraryDB:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public LibraryDB(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=LMSBLAZOREXAM1;Trusted_Connection=True");

    }
}
