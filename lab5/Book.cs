namespace lab5
{
    public class Book
    {
        // Primary Key (Auto-incremented by SQL Server)
        public int BookID { get; set; }

        // The book's title column
        public string Title { get; set; }

        // Foreign Key pointing directly to the Author table
        public int AuthorID { get; set; }

        // Navigation Property: Every single Book belongs to exactly one Author
        public virtual Author Author { get; set; }
    }
}