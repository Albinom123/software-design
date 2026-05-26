using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace lab6
{
    public class BookstoreContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Adjust the connection string if your local SQL Server instance has a different name
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}