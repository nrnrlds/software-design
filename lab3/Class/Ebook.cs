using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Class
{
    public class Ebook : Book
    {
        public string FormatType { get; set; }


        public override string GetInfo()
        {
            return $"{Title} ({FormatType}) by: ({Author})";
        }
    }
}
