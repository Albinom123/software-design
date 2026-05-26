using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace lab5
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}