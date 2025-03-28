﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreTest
{
    public class Ebook : Book
    {
        public int FileSizeMB { get; set; }

        public override string GetInfo() => $"{Title} (Ebook, {FileSizeMB}MB)";
    }
}
