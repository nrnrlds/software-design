using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreTest
{
    public class Magazine : Book
    {
        private int _issueNumber;

        public override string GetInfo() => $"{Title} - Issue {IssueNumber} - by {Author}";

        public int IssueNumber
        {
            get => _issueNumber;
            set => _issueNumber = value <= 0
                ? throw new ArgumentException("Issue number must be positive")
                : value;
        }
    }
}
