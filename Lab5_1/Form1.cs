namespace Lab5_1
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
    }
}
