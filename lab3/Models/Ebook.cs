using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class EBook : Book
    {
        public string Format { get; set; }

        public EBook(string title, string author, int year, string format)
            : base(title, author, year)
        {
            Format = format;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Format: {Format}";
        }
    }
}
