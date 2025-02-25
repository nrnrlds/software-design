using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.BookstoreSystem.Models
{
    public class Ebook : Book
    {
        public string Format { get; set; }

        public Ebook(string title, string author, string format)
            : base(title, author)
        {
            Format = format;
        }

        public override string GetInfo()
        {
            return $"Ebook: {Title} by {Author} ({Format})";
        }
    }
}
