﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Class
{
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public override string GetInfo()
        {
            return $"{Title} - Issue {IssueNumber} - by: ({Author}) ";
        }
    }
}
