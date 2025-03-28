using Microsoft.EntityFrameworkCore;

namespace lab5
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

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(x => x.Author)
                    .Select(x => $"{x.BookID} - {x.Title} by {x.Author.Name}")
                    .ToList();
                return booksWithAuthors;
            }
        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                // Check if author already exists
                var author = context.Authors.FirstOrDefault(a => a.Name == authorName);
                if (author == null)
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                    context.SaveChanges(); // Save to get AuthorID
                }

                // Add the book
                var book = new Book { Title = bookTitle, AuthorID = author.AuthorID };
                context.Books.Add(book);
                context.SaveChanges();


            }
        }
        public void DeleteBookByID(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Book not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public List<string> SearchBooksByAuthor(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name == authorName)
                    .Select(b => $"{b.BookID} - {b.Title}")
                    .ToList();
            }
        }
        public void UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(x => x.Author).FirstOrDefault(x => x.BookID == bookId);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthor.Text.Trim();
            string bookTitle = txtTitle.Text.Trim();

            if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Please enter both an author name and a book title.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                AddAuthorWithBook(authorName, bookTitle);
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the book list
                ListBook.DataSource = null;
                ListBook.DataSource = GetBooksWithAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(txtID.Text);
            UpdateBookAndAuthor(bookId, txtTitle.Text, txtAuthor.Text);
            MessageBox.Show("Book and Author update sucessfully.");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            ListBook.DataSource = books;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDelete.Text, out int bookId))
            {
                DeleteBookByID(bookId);
                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListBook.DataSource = null;
                ListBook.DataSource = GetBooksWithAuthors();
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string authorName = txtSearchAuthor.Text.Trim();
            if (string.IsNullOrEmpty(authorName))
            {
                MessageBox.Show("Please enter an author name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListBook.DataSource = null;
            ListBook.DataSource = SearchBooksByAuthor(authorName);
        }
    }
}
