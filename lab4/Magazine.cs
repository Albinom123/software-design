    using System;

namespace lab4
{

    public class Magazine : Book
    {
         public int IssueNumber { get; set; }

        /* public Magazine(string title, string author, int year, int issueNumber)
             : base(title, author, year)
         {
             IssueNumber = issueNumber;
         }*/

            public Magazine(string title, string author, int year, int issueNumber)
                : base(title, author, year)
            {
                if (issueNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("Issue number cannot be negative.");
                }
                IssueNumber = issueNumber;
            }

            public override string GetInfo()
            {             
                return $"{Title} - Issue {IssueNumber}";
            }
        }
    }