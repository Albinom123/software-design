namespace lab7
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
    }
}