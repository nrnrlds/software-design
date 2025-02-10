using lab3.Models;
using static lab3.Models.Book;

namespace lab3
{
    public partial class Form1 : Form
    {
        private List<Book> books; // Declare the 'books' variable at the class level

        public Form1()
        {
            InitializeComponent();
            InitializeBooks(); // Initialize the 'books' list
            InitializeBookTypeComboBox();
        }

        private void InitializeBooks()
        {
            books = new List<Book>
            {
                new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925),
                new Magazine("National Geographic", "Various", 2023, "January 2023"),
                new EBook("Clean Code", "Robert C. Martin", 2008, "PDF"),
                new Textbook("Mathematics for Engineers", "John Doe", 2020, "Engineering"),
                new AudioBook("The Alchemist", "Paulo Coelho", 1988, "5 hours", "Jeremy Irons")
            };
        }

        private void InitializeBookTypeComboBox()
        {
            BookTypeComboBox.Items.AddRange(new string[] { "Book", "Magazine", "EBook", "Textbook", "AudioBook" });
            BookTypeComboBox.SelectedIndex = 0; // Set default selection
        }


        private void AddBookButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
            int year = int.Parse(YearTextBox.Text); // Add error handling for invalid input

            switch (BookTypeComboBox.SelectedItem.ToString())
            {
                case "Book":
                    books.Add(new Book(title, author, year));
                    break;
                case "Magazine":
                    string issue = IssueTextBox.Text;
                    books.Add(new Magazine(title, author, year, issue));
                    break;
                case "EBook":
                    string format = FormatTextBox.Text;
                    books.Add(new EBook(title, author, year, format));
                    break;
                case "Textbook":
                    string subject = SubjectTextBox.Text;
                    books.Add(new Textbook(title, author, year, subject));
                    break;
                case "AudioBook":
                    string duration = DurationTextBox.Text;
                    string narrator = NarratorTextBox.Text;
                    books.Add(new AudioBook(title, author, year, duration, narrator));
                    break;
            }

            // Clear input fields after adding
            ClearInputFields();
            MessageBox.Show("Book added successfully!");
        }

        private void ClearInputFields()
        {
            TitleTextBox.Clear();
            AuthorTextBox.Clear();
            YearTextBox.Clear();
            IssueTextBox.Clear();
            FormatTextBox.Clear();
            SubjectTextBox.Clear();
            DurationTextBox.Clear();
            NarratorTextBox.Clear();
        }

        private void IssueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayBooksButton_Click_1(object sender, EventArgs e)
        {
            BookListBox.Items.Clear(); // Clear the ListBox before adding new items

            foreach (var book in books)
            {
                BookListBox.Items.Add(book.GetInfo()); // Add book information to the ListBox
            }
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            BookListBox.Items.Clear();
        }
    }

}
