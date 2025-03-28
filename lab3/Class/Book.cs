using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Class
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }
    }
}
