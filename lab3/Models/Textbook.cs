using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class Textbook : Book
    {
        public string Subject { get; set; }

        public Textbook(string title, string author, int year, string subject)
            : base(title, author, year)
        {
            Subject = subject;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Subject: {Subject}";
        }
    }
}
