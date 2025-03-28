using Task_3.Class;

namespace Task_3
{
    public partial class Task_3 : Form
    {
        public Task_3()
        {
            InitializeComponent();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] books =
                new Book[]
                {
                    new Magazine { Title = "The Business", Author = "Madison George", IssueNumber = 37 },
                    new Magazine { Title = "Vanity Fair", Author = "Jennifer Lawrence", IssueNumber = 14 },
                    new Ebook { Title = "Power", Author = "Jeffrey Pfeffer", FormatType="PDF" },
                    new Book { Title="Sweet Revenge", Author = "Miranda Reigns"},
                    new Ebook { Title = "A Thoughtless Seven", Author = "Amy Le Feure", FormatType="PDF" },
                    new Book { Title = "Funny Story", Author = "Emily Henry" },
               
                    new Textbook { Title="Linear Algebra", Author= "Sheldon Axler", Subject= "Algebra" },
                    new Textbook.AudioBook{Title= "In a Rush",Author="Kate Canterbary", Duration= 14, Narrator="Rose Dioro, Aaron Shedlock"}
                };
            DisplayBooks(books);
        }

        private void DisplayBooks(Book[] books)
        {
            ListBooks.Items.Clear();

            foreach (var book in books)
            {
                string infoMessage = book.GetInfo();
                Console.WriteLine(infoMessage);
                ListBooks.Items.Add(infoMessage);
            }
        }
    }
}
