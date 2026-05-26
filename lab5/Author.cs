using System.Collections.Generic;

namespace lab5
{
    public class Author
    {
        // Primary Key (Auto-incremented by SQL Server)
        public int AuthorID { get; set; }

        // The author's name column
        public string Name { get; set; }

        // Navigation Property: One Author can have a collection of many Books
        // The 'virtual' keyword enables Entity Framework's Lazy Loading feature
        public virtual ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}