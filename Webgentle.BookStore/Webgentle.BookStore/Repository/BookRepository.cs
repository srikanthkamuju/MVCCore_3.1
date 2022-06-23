using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    
    public class BookRepository
    {
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
        {
            new BookModel(){ Id=1, Title="C#", Author="Srikanth"},
            new BookModel(){ Id=2, Title="MVC", Author="Srikanth"},
            new BookModel(){ Id=3, Title="ANGULAR", Author="Srikanth"},
            new BookModel(){ Id=4, Title="SQL", Author="Srikanth"},
        };
        }
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int Id)
        {
            return DataSource().Where(x => x.Id == Id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string Title, string authorName)
        {
            return DataSource().Where(x => x.Title == Title && x.Author == authorName).ToList();
        }
    }
}
