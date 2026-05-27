using System;
using System.Data;
using System.Linq;
using System.Net.Http;     
using System.Threading.Tasks;  
using System.Windows.Forms;
using Newtonsoft.Json.Linq;   

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        public async Task<string> GetBookInfoFromAPIAsync(string isbn)
        {
            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(apiUrl);

                    JObject jsonResponse = JObject.Parse(response);

                    if (jsonResponse["items"] == null || !jsonResponse["items"].Any())
                    {
                        return "Error: No records discovered matching this specific ISBN.";
                    }

                    var volumeInfo = jsonResponse["items"][0]["volumeInfo"];
                    string title = volumeInfo["title"]?.ToString() ?? "Unknown Title";

                    var authorsArray = volumeInfo["authors"];
                    string authors = authorsArray != null
                        ? string.Join(", ", authorsArray.Select(a => a.ToString()))
                        : "Unknown Author";

                    return $"Title: {title}\r\nAuthors: {authors}";
                }
            }
            catch (HttpRequestException)
            {
                
                return "Error: Unable to fetch data from the API. Please verify your network connections.";
            }
            catch (Exception ex)
            {
                return $"Unexpected Error Encountered: {ex.Message}";
            }
        }

    
        private async void btnFetchBook_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please provide a valid ISBN search string value.", "Validation Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtBookDetails.Text = "Querying API architecture... Please wait.";
            txtBookDetails.Text = await GetBookInfoFromAPIAsync(isbn);
        }
      
        // TASK 3: STUDENT CHALLENGE (Search Books by Author with Basic Pagination)
    
        public async Task SearchBooksByAuthorAsync(string authorName, int pageNumber = 1)
        {
            int maxResultsPerPage = 10;
            int startIndex = (pageNumber - 1) * maxResultsPerPage;
            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q=inauthor:{Uri.EscapeDataString(authorName)}&startIndex={startIndex}&maxResults={maxResultsPerPage}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(apiUrl);
                    JObject jsonResponse = JObject.Parse(response);

                    lstBooks.Items.Clear();

                    if (jsonResponse["items"] != null)
                    {
                        foreach (var item in jsonResponse["items"])
                        {
                            string title = item["volumeInfo"]?["title"]?.ToString() ?? "Unknown Title";
                            lstBooks.Items.Add(title);
                        }
                    }
                    else
                    {
                        lstBooks.Items.Add("No books matched this specific author target query.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search operation initialization failure: {ex.Message}");
            }
        }

    
        private async void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string author = txtAuthorSearch.Text.Trim();

            if (string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please input an author name payload first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

       
            await SearchBooksByAuthorAsync(author, 1);
        }
    }
}