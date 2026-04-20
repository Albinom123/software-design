using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    /*  public class Ebook : Book
      {
          public int FileSizeMB { get; set; }

          public Ebook(string title, string author, int year, int fileSizeMB)
              : base(title, author, year)
          {
              FileSizeMB = fileSizeMB;
          }

          public override string GetInfo()
          {
              return $"{Title} (Ebook, {FileSizeMB}MB)";
          }
      } */
   
    public class Ebook : Book
    {
      
        public int FileSizeMB { get; set; }

        public Ebook(string title, string author, int year, int fileSizeMB)
            : base(title, author, year)
        {
            
            if (fileSizeMB <= 0)
            {
                throw new ArgumentException("File size must be greater than 0.");
            }
            FileSizeMB = fileSizeMB;
        }

   
        public override string GetInfo()
        {
            return $"{Title} (Ebook, {FileSizeMB}MB)";
        }
    }

}
