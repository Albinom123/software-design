using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ==========================================
        // TASK 5: CREATE OPERATION
        // ==========================================
        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                // Create a new author entity
                var author = new Author { Name = authorName };

                // Create a new book entity and link it to the author
                var book = new Book { Title = bookTitle, Author = author };

                // Add records to memory tracking sets
                context.Authors.Add(author);
                context.Books.Add(book);

                // Commit and save to the SQL Server database
                context.SaveChanges();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text.Trim();
            string bookTitle = txtBookTitle.Text.Trim();

            if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Please enter both an Author Name and a Book Title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AddAuthorWithBook(authorName, bookTitle);
                MessageBox.Show("Author and Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the input fields for the next entry
                txtAuthorName.Clear();
                txtBookTitle.Clear();

                // Automatically refresh the list box display
                btnShowBooks_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // TASK 5: READ OPERATION
        // ==========================================
        public List<string> GetBooksWithAuthors()
        {
            var bookListStrings = new List<string>();

            using (var context = new BookstoreContext())
            {
                // Use .Include to eagerly load the Author records for each Book
                var books = context.Books.Include(b => b.Author).ToList();

                foreach (var b in books)
                {
                    // Format a readable string line item for the ListBox
                    bookListStrings.Add($"ID: {b.BookID} | Title: {b.Title} by {b.Author.Name}");
                }
            }

            return bookListStrings;
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxBooks.Items.Clear();
                var books = GetBooksWithAuthors();

                foreach (var displayItem in books)
                {
                    listBoxBooks.Items.Add(displayItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // TASK 6: UPDATE OPERATION
        // ==========================================
        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                // Find the book by its unique primary key ID and include the linked author
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);

                if (book != null)
                {
                    // Modify properties in memory
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;

                    // Entity Framework automatically tracks these updates and applies them
                    context.SaveChanges();
                    MessageBox.Show("Book and Author updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book record not found matching that ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newTitle = txtBookTitle.Text.Trim();
            string newAuthorName = txtAuthorName.Text.Trim();

            if (string.IsNullOrEmpty(newTitle) || string.IsNullOrEmpty(newAuthorName))
            {
                MessageBox.Show("Please populate both the Book Title and Author Name fields with the new values.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UpdateBookAndAuthor(bookId, newTitle, newAuthorName);
                txtBookID.Clear();
                txtBookTitle.Clear();
                txtAuthorName.Clear();
                btnShowBooks_Click(sender, e); // Refresh display
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // TASK 7: STUDENT CHALLENGE (DELETE)
        // ==========================================
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);

                if (book != null)
                {
                    // Remove the entity row
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Book tracking record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No book matched that ID setup.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please provide a valid numeric Book ID to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DeleteBook(bookId);
                txtBookID.Clear();
                btnShowBooks_Click(sender, e); // Refresh display
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing removal: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // TASK 7: STUDENT CHALLENGE (SEARCH AUTHOR)
        // ==========================================
        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string searchName = txtAuthorName.Text.Trim();

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Please enter an Author Name phrase to search for.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                listBoxBooks.Items.Clear();

                using (var context = new BookstoreContext())
                {
                    // Filter records using a LINQ .Where query mapping string values
                    var searchResults = context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Author.Name.Contains(searchName))
                        .ToList();

                    if (searchResults.Count == 0)
                    {
                        listBoxBooks.Items.Add("No matches found for that author.");
                        return;
                    }

                    foreach (var b in searchResults)
                    {
                        listBoxBooks.Items.Add($"ID: {b.BookID} | Title: {b.Title} by {b.Author.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error running search query: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}