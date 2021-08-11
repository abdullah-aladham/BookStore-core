using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.repositories
{
    public class BookRepository : IBookStore_repo<Book>
    {
        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Book_id=1,
                    Book_name="Asp.net Core For beginners",
                    b_desc="This books aims to teach the beginners the fundementals of Asp.net Core",
                },
                new Book
                {
                    Book_id=2,
                    Book_name="Java For beginners",
                    b_desc="This books aims to teach the beginners the fundementals of Java",
                },
                new Book
                {
                    Book_id=3,
                    Book_name="Asp.net MVC For beginners",
                    b_desc="This books aims to teach the beginners the fundementals of Asp.net MVC  ",
                },
            };
        }
        public void add(Book entity)
        {
            books.Add(entity);
        }

        public void delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Book_id == id);
            return book;     
        }

        public IList<Book> list()
        {
            return books;
        }

        public void update(int id ,Book newbook)
        {
            var book = Find(id);
            book.Book_name = newbook.Book_name;
            book.b_desc = newbook.b_desc;
            book.Author = newbook.Author;
        }
    }
}
