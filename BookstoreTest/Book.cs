using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreTest
{
    public class Book
    {
        private string _title;
        private string _author;

        public virtual string GetInfo() => $"{Title} by {Author}";

        public string Title
        {
            get => _title;
            set => _title = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Title cannot be empty")
                : value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }
    }
}
