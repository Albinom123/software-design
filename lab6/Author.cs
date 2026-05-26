
using System.Collections.Generic;

namespace lab6
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        // Navigation property for Entity Framework
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}