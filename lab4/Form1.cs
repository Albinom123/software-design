namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            // 1. Clear the list so we don't duplicate items every click
            lstBooks.Items.Clear();

            // 2. Create an array of your classes (Polymorphism in action!)
            lab4.Book[] myLibrary = new lab4.Book[]
   {
    new lab4.Book("Journey to The West", "Wu Cheng'en", 1592),
    new lab4.Magazine("Tech Monthly", "Jane Doe", 2024, 105),
    new lab4.Ebook("Digital C#", "Mark Jones", 2023, 12),
    new lab4.Textbook("Biology 101", "Dr. Smith", 2022, "Science")
   };

            // 3. Loop through the array and call GetInfo() for each one
            foreach (lab4.Book b in myLibrary)
            {
           
                lstBooks.Items.Add(b.GetInfo());
            }
        }
    }
}