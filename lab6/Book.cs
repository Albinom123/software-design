namespace lab6
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        // Foreign Key and Navigation Property
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}