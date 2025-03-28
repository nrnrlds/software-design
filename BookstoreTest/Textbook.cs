using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreTest
{
    public class Textbook : Book
    {
        private string _subject;

        public override string GetInfo() => $"{Title} on Subject '{Subject}'";

        public string Subject
        {
            get => _subject;
            set => _subject = string.IsNullOrWhiteSpace(value)
                ? throw new ArgumentException("Subject cannot be empty")
                : value;
        }
    }
}
