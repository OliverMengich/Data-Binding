using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Binding.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string CoverPage { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Future", CoverPage = "Assets/twitter.png" });
            books.Add(new Book { BookId = 2, Title = "Meawo", Author = "Neymar", CoverPage = "Assets/instagram.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Messi", CoverPage = "Assets/facebook.png" });

            books.Add(new Book { BookId = 4, Title = "Etim", Author = "Nazario", CoverPage = "Assets/twitter.png" });
            books.Add(new Book { BookId = 5, Title = "Erat", Author = "Future", CoverPage = "Assets/linkedin.png" });
            books.Add(new Book { BookId = 6, Title = "Feugit eros libex", Author = "Option", CoverPage = "Assets/twitter.png" });

            books.Add(new Book { BookId = 7, Title = "Nonummy erat", Author = "Future", CoverPage = "Assets/twitter.png" });

            books.Add(new Book { BookId = 8, Title = "Per Modo", Author = "Future", CoverPage = "Assets/linkedin.png" });
            books.Add(new Book { BookId = 9, Title = "Vulpate", Author = "Accumsan", CoverPage = "Assets/twitter.png" });

            books.Add(new Book { BookId = 10, Title = "Decima", Author = "Legunt Xaepius", CoverPage = "Assets/twitter.png" });

            books.Add(new Book { BookId = 11, Title = "Suscipit Ad", Author = "Verro Tation", CoverPage = "Assets/twitter.png" });

            books.Add(new Book { BookId = 12, Title = "Aliquip", Author = "Tuffy Tibbles", CoverPage = "Assets/instagram.png" });

            books.Add(new Book { BookId = 13, Title = "Vulpate", Author = "Magna", CoverPage = "Assets/facebook.png" });
            return books;
        }
    }
}
