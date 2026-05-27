using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace lab7
{
    public partial class Form1 : Form
    {
        private const int pageSize = 18;
        private int currentPage = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page: {currentPage}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Initialization Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // TASK 1: ASYNCHRONOUS PAGINATION

        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .OrderBy(b => b.BookID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return books;
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            if (books.Count == 0 && currentPage > 1)
            {
                currentPage--;
                MessageBox.Show("You have reached the last page.", "Pagination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page: {currentPage}";
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                var books = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = books;
                lblPageNumber.Text = $"Page: {currentPage}";
            }
        }

        // TASK 2: ERROR HANDLING IN ASYNC OPERATIONS
        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    await context.SaveChangesAsync();
                    MessageBox.Show("Book and Author saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text.Trim();
            string bookTitle = txtBookTitle.Text.Trim();

            if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Please fill out all fields.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await SaveBookWithHandlingAsync(bookTitle, authorName);

            txtAuthorName.Clear();
            txtBookTitle.Clear();

           
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
        }

        // TASK 3: ASYNCHRONOUS FILE EXPORT

        public async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                   
                    await writer.WriteLineAsync(book);
                }
            }
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Save Book List"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("Books exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // TASK 4: STUDENT CHALLENGES

        // Challenge 1: Asynchronous Search with Error Handling
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearchTitle.Text.Trim();
            if (string.IsNullOrEmpty(searchKeyword))
            {
                var defaultBooks = await GetBooksByPageAsync(currentPage);
                listBoxBooks.DataSource = defaultBooks;
                lblPageNumber.Text = $"Page: {currentPage}";
                return;
            }

            try
            {
                using (var context = new BookstoreContext())
                {
                    var results = await context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Title.Contains(searchKeyword))
                        .Select(b => $"{b.Title} by {b.Author.Name}")
                        .ToListAsync();

                    listBoxBooks.DataSource = results;
                    lblPageNumber.Text = "Search Results";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Open Book List to Import"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var context = new BookstoreContext())
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = await reader.ReadLineAsync()) != null)
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 2)
                            {
                                var author = new Author { Name = parts[1].Trim() };
                                var book = new Book { Title = parts[0].Trim(), Author = author };

                                context.Authors.Add(author);
                                context.Books.Add(book);
                            }
                        }
                        await context.SaveChangesAsync();
                        MessageBox.Show("Asynchronous database import completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var books = await GetBooksByPageAsync(currentPage);
                        listBoxBooks.DataSource = books;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Import failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}