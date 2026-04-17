using System.Net;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
// Task 1
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author}, Issue {IssueNumber}";
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine
            {
                Title = "Tech Weekly",
                Author = "Jane Doe",
                IssueNumber = 67,
            };
            MessageBox.Show(myBook.GetInfo());
        }

        //Task 2
        public class Ebook : Book
        {
            public double FileSizeMB { get; set; }
            public override string GetInfo()
            {
                return $"[Ebook] {Title} by {Author} ({FileSizeMB}MB)";
            }
        }

        public void ProcessBooks(List<Book> books)
        {
            lstBooks.Items.Clear();

            foreach (Book b in books)
            {

                lstBooks.Items.Add(b.GetInfo());
            }
        }


        private void btnShowInfo2_Click(object sender, EventArgs e)
        {

            List<Book> myLibrary = new List<Book>();

            myLibrary.Add(new Book
            {
                Title = "The Great Catsby",
                Author = "Cat in the MAt"
            });

            myLibrary.Add(new Magazine
            {
                Title = "Tech Weekly",
                Author = "Jane Doe",
                IssueNumber = 67
            });

            myLibrary.Add(new Ebook
            {
                Title = "How to Scam",
                Author = "Mr. Least",
                FileSizeMB = 4.5
            });

         
            ProcessBooks(myLibrary);
        }

      //Task 3
        public class Textbook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"[Textbook] {Title} ({Subject}) by {Author}";
            }
        }

 
        public class AudioBook : Book
        {
            public string Narrator { get; set; }
            public int DurationMinutes { get; set; }

            public override string GetInfo()
            {
                return $"[AudioBook] {Title} by {Author}, Narrated by {Narrator} [{DurationMinutes} mins]";
            }
        }
        private void btnShowInfo3_Click(object sender, EventArgs e)
        {

            List<Book> myLibrary = new List<Book>();


            myLibrary.Add(new Magazine
            {
                Title = "Tech Weekly",
                Author = "Jane Doe",
                IssueNumber = 67
            });

          
            myLibrary.Add(new Textbook
            {
                Title = "Advanced Geology",
                Author = "Dr. Craft",
                Subject = "Science"
            });

            myLibrary.Add(new AudioBook
            {
                Title = "The Robb'it",
                Author = "N.I.G.G.A Token",
                Narrator = "Andy Serkis",
                DurationMinutes = 620
            });

           
            ProcessBooks(myLibrary);
        }
    }
}




