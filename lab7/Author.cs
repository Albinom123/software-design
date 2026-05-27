using System.Collections.Generic;

namespace lab7
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}