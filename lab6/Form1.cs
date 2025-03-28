using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public async Task<List<string>> GetBooksAsync()
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    return await context.Books
                        .Include(x => x.Author)
                        .Select(x => $"{x.BookID}: {x.Title} by {x.Author.Name}")
                        .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching books: {ex.Message}");
                return new List<string>();
            }
        }

        private async void btnFetch_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Visible = true;
                progressBar.Value = 0;
                var progress = new Progress<int>(value => progressBar.Value = value);
                var books = await GetBooksAsyncWithProgress(progress);
                listBookFetch.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching books: {ex.Message}");
            }
            finally
            {
                progressBar.Visible = false;
            }
        }
        private async Task<List<string>> GetBooksAsyncWithProgress(IProgress<int> progress)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var books = await context.Books.Include(x => x.Author).ToListAsync();
                    var result = new List<string>();
                    int count = books.Count;  // Fixed typo here (.count -> .Count)

                    for (int i = 0; i < count; i++)
                    {
                        result.Add($"{books[i].BookID}: {books[i].Title} by {books[i].Author.Name}");
                        progress?.Report((i + 1) * 100 / count);
                        await Task.Delay(100);
                    }
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}");
                return new List<string>();
            }
        }
        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(bookTitle) || string.IsNullOrWhiteSpace(authorName))
                {
                    MessageBox.Show("Book title and author name cannot be empty.");
                    return;
                }

                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };
                    context.Authors.Add(author);
                    context.Books.Add(book);
                    await context.SaveChangesAsync();
                    MessageBox.Show("Book and Author saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving book: {ex.Message}");
            }
        }
        public async Task UpdateBookAsync(int bookId, string newTitle, string newAuthorName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(newTitle) || string.IsNullOrWhiteSpace(newAuthorName))
                {
                    MessageBox.Show("New title and author name cannot be empty.");
                    return;
                }

                using (var context = new BookstoreContext())
                {
                    var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookId);
                    if (book != null)
                    {
                        book.Title = newTitle;
                        book.Author.Name = newAuthorName;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Book updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Book not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}");
            }
        }

        public async Task<List<string>> SearchBooksAsync(string searchTerm)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    return new List<string>();
                }

                using (var context = new BookstoreContext())
                {
                    return await context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Title.Contains(searchTerm) || b.Author.Name.Contains(searchTerm))
                        .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                        .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching books: {ex.Message}");
                return new List<string>();
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var results = await SearchBooksAsync(txtSearch.Text);
                listBookSearch.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                await SaveBookAsync(txtTitle.Text, txtAuthor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save error: {ex.Message}");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int bookId))
                {
                    MessageBox.Show("Invalid Book ID.");
                    return;
                }
                await UpdateBookAsync(bookId, txtTitle.Text, txtAuthor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update error: {ex.Message}");
            }
        }
    }
}
