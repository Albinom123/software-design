using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace lab5
{
    public class BookstoreContext : DbContext
    {
        // Expose our entity sets as queryable tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        // Connect our application to the local MS SQL database instance
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Uses the connection string template provided in Task 4 of your manual
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BookstoreDB;Trusted_Connection=True;");
        }
    }
}