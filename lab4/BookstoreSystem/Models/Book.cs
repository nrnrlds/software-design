using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.BookstoreSystem.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public virtual string GetInfo()
        {
            return $"Book: {Title} by {Author}";
        }
    }
}
