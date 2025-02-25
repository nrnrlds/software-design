using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.BookstoreSystem.Models
{
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, string author, int issueNumber)
            : base(title, author)
        {
            IssueNumber = issueNumber;
        }

        public override string GetInfo()
        {
            return $"Magazine: {Title}, Issue #{IssueNumber} by {Author}";
        }
    }
}
