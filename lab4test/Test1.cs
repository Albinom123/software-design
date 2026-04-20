using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab4; // This connects to your main project

namespace lab4test
{
    /* [TestClass]
     public class Test1
     {
         [TestMethod]
         public void TestBookCreation()
         {
             // Note: Use the same values in the constructor and the Assert
             Book book = new Book("Journey to The West", "Some Chinese Guy", 2025);

             Assert.AreEqual("Journey to The West", book.Title);
             Assert.AreEqual("Some Chinese Guy", book.Author);
         }

         [TestMethod]
         public void TestPolymorphism_GetInfo_Method()
         {
             // Arrange: This array holds a mix of all three types
             Book[] books = new Book[]
             {
         new Book("Generic Book", "John Smith", 2020),
         new Magazine("Tech Weekly", "Jane Doe", 2021, 12),
         new Ebook("Learn C#", "Mark Jones", 2022, 5) // Testing Ebook here!
             };

             // Act & Assert: Checking that each one uses its own version of GetInfo()
             Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
             Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
             Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
         }

         [TestMethod]
         [ExpectedException(typeof(ArgumentException))]
         public void TestInvalidMagazineCreation()
         {
             Magazine magazine = new Magazine {Title = "Invaled", Author = "Jane Doe", IssueNumber = -1 };
         }
         [TestMethod]
         [ExpectedException(typeof(ArgumentException))]
         public void TestInvalidEbookCreation()
         {
             Ebook ebook = new Ebook { Title = "Invalid Ebook", Author = "Mark Jones", FileSizeMB = -5 };
         }
         [TestMethod]
         [ExpectedException(typeof(ArgumentException))]
         public void TestInvalidBookCreation()
         {
             Book book = new Book { Title = "Invalid Book", Author = "John Smith", Year = -2020 };
         }
     } */

    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestBookCreation()
        {
            Book book = new Book("Journey to The West", "Some Chinese Guy", 2025);
            Assert.AreEqual("Journey to The West", book.Title);
            Assert.AreEqual("Some Chinese Guy", book.Author);
        }

        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            Book[] books = new Book[]
            {
                new Book("Generic Book", "John Smith", 2020),
                new Magazine("Tech Weekly", "Jane Doe", 2021, 12),
                new Ebook("Learn C#", "Mark Jones", 2022, 5)
            };

            Assert.AreEqual("Generic Book by John Smith", books[0].GetInfo());
            Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
            Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
        }

        // --- CHALLENGE TESTS ---

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInvalidMagazineCreation()
        {
          
            new Magazine("Invalid", "Jane Doe", 2024, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidBookCreation_EmptyTitle()
        {
           
            new Book("", "John Smith", 2020);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTextbook_EmptySubject()
        {
           
            new Textbook("Math 101", "Prof. X", 2024, "");
        }
    }
}