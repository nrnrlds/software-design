using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Models
{
    public class Magazine : Book
    {
        public string Issue { get; set; }

        public Magazine(string title, string author, int year, string issue)
            : base(title, author, year)
        {
            Issue = issue;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Issue: {Issue}";
        }
    }
}
