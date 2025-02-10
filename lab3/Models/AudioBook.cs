using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Models
{
  
    public class AudioBook : Book
        {
            public string Duration { get; set; }
            public string Narrator { get; set; }

            public AudioBook(string title, string author, int year, string duration, string narrator)
                : base(title, author, year)
            {
                Duration = duration;
                Narrator = narrator;
            }

            public override string GetInfo()
          {
                return base.GetInfo() + $", Duration: {Duration}, Narrator: {Narrator}";
            }
        }
}
