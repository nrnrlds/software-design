using lab4.BookstoreSystem.Models;

namespace BookstoreSystem.Models
{
    public class Textbook : Book
    {
        public string Subject { get; set; }

        public Textbook(string title, string author, string subject)
            : base(title, author)
        {
            if (string.IsNullOrEmpty(subject))
            {
                throw new ArgumentException("Subject cannot be empty.");
            }
            Subject = subject;
        }

        public override string GetInfo()
        {
            return $"Textbook: {Title} by {Author} (Subject: {Subject})";
        }
    }
}