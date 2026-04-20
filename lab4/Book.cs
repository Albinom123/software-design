using System;
namespace lab4
{
    /*public class Book 
 {
     public string Title { get; set; }
     public string Author { get; set; }
     public int Year { get; set; }

     public Book(string title, string author, int year)
     {
         Title = title;
         Author = author;
         Year = year;
     }*/
   

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }

            public Book(string title, string author, int year)
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                Title = title;
                Author = author;
                Year = year;
            }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }
    }

