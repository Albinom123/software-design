using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    
        public class Textbook : Book
        {
            public string Subject { get; set; }

            public Textbook(string title, string author, int year, string subject)
                : base(title, author, year)
            {
                if (string.IsNullOrWhiteSpace(subject))
                {
                    throw new ArgumentException("Subject cannot be empty.");
                }
                Subject = subject;
            }
            public override string GetInfo()
            {
                return $"{Title} (Subject: {Subject})";
            }
        }
    
}
