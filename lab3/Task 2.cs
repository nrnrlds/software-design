using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab3.Form1;

namespace lab3
{
    public partial class Task_2 : Form
    {
        public Task_2()
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
                };


            ProcessAndDisplayBooks(books);
        }
        private void ProcessAndDisplayBooks(Book[] books)
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


    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }
    }

    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber} - by: ({Author}) ";
        }
    }

    public class Ebook : Book
    {
        public string FormatType { get; set; }


        public override string GetInfo()
        {
            return $"{Title} ({FormatType}) by: ({Author})";
        }
    }

}
