using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Helper structure to bind the actual Database ID to the ListBox hidden from the plain text view
        public class BookDisplayItem
        {
            public int BookId { get; set; }
            public string DisplayText { get; set; }
            public override string ToString() => DisplayText;
        }

        // ==========================================
        // TASK 1 & 3: FETCH DATA WITH PROGRESS
        // ==========================================
        public async Task FetchBooksWithProgressAsync(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                lblFetchStatus.Text = "Fetch Status: Connecting...";
                progress.Report(20);
                await Task.Delay(150);

                lblFetchStatus.Text = "Fetch Status: Processing Query...";
                progress.Report(60);
                var booksList = await context.Books.Include(b => b.Author).ToListAsync();

                progress.Report(80);
                var displayList = booksList.Select(b => new BookDisplayItem
                {
                    BookId = b.BookId,
                    DisplayText = $"{b.Title} by {b.Author?.Name}"
                }).ToList();
                await Task.Delay(150);

                progress.Report(100);
                lblFetchStatus.Text = "Fetch Status: Complete!";

                listBoxBooks.DataSource = displayList;
            }
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            progressBarProgress.Value = 0;
            var progressHandler = new Progress<int>(val => progressBarProgress.Value = val);

            await FetchBooksWithProgressAsync(progressHandler);
        }

        // ==========================================
        // TASK 2: ADD / SAVE DATA ASYNCHRONOUSLY
        // ==========================================
        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);

                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text) || string.IsNullOrWhiteSpace(txtAuthorName.Text))
            {
                MessageBox.Show("Please fill out both Title and Author fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await SaveBookAsync(txtBookTitle.Text, txtAuthorName.Text);

            FormUtilities.ClearFormFields(this);
            MessageBox.Show("Book and Author saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Automatically refresh the view
            btnFetchBooks.PerformClick();
        }

        // ==========================================
        // TASK 3 CHALLENGE: UPDATE & DELETE ASYNCHRONOUSLY
        // ==========================================
        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookId == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    if (book.Author != null) book.Author.Name = newAuthorName;
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is BookDisplayItem selectedBook)
            {
                if (string.IsNullOrWhiteSpace(txtBookTitle.Text) || string.IsNullOrWhiteSpace(txtAuthorName.Text))
                {
                    MessageBox.Show("Please enter new details in the text inputs above first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await UpdateBookAsync(selectedBook.BookId, txtBookTitle.Text, txtAuthorName.Text);
                MessageBox.Show("Selected records changed cleanly!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormUtilities.ClearFormFields(this);
                btnFetchBooks.PerformClick();
            }
            else
            {
                MessageBox.Show("Please select a book from the list box inventory layout to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public async Task DeleteBookAsync(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FindAsync(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is BookDisplayItem selectedBook)
            {
                var dialogResult = MessageBox.Show("Are you sure you want to drop this record item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    await DeleteBookAsync(selectedBook.BookId);
                    MessageBox.Show("Record item erased from database server.", "Dropped", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    btnFetchBooks.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Please highlight an index inside the list display first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // ==========================================
        // TASK 3 CHALLENGE: SEARCH ASYNCHRONOUSLY
        // ==========================================
        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            // If search box is cleared, automatically re-load all inventory items
            if (string.IsNullOrWhiteSpace(query) || query == "Enter title keywords...")
            {
                return;
            }

            using (var context = new BookstoreContext())
            {
                var matches = await context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.Contains(query))
                    .Select(b => new BookDisplayItem
                    {
                        BookId = b.BookId,
                        DisplayText = $"{b.Title} by {b.Author.Name}"
                    })
                    .ToListAsync();

                listBoxBooks.DataSource = matches;
            }
        }

        // Fill inputs automatically when you click an inventory item to easily update it
        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem is BookDisplayItem selectedBook)
            {
                // Simple parsing to split text details into edit boxes
                string[] parts = selectedBook.DisplayText.Split(new string[] { " by " }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    txtBookTitle.Text = parts[0];
                    txtAuthorName.Text = parts[1];
                }
            }
        }
    }

    // Renamed helper class to keep standard system window components working perfectly
    public static class FormUtilities
    {
        public static void ClearFormFields(Form form)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox box) box.Clear();

                // Also scan embedded container layouts
                if (c.HasChildren)
                {
                    foreach (Control child in c.Controls)
                    {
                        if (child is TextBox childBox) childBox.Clear();
                    }
                }
            }
        }
    }
}