using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BookRepository
{
    public class Book //creating a class
    {
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public int PublishedYear { get; set; }
        public double Price { get; set; }

        public Book(int id, string btitle, string aname, int pubyr, double price) //making the class public
        {
            this.BookID = id;
            this.BookTitle = btitle;
            this.AuthorName = aname;
            this.PublishedYear = pubyr;
            this.Price = price;

        }
    }
    public interface CRUD //implmenting crud interface
    {
        void Create(Book obj);
        ICollection<Book> Read();
        void Update(Book obj);
        void Delete(Book obj);
    }

    public class BookRepositories : CRUD
    {
        public List<Book> booklist; //making list public for use

        public BookRepositories()
        {
            booklist = new List<Book>();
        }

        public void Create(Book obj)
        {
            booklist.Add(obj);
        }

        public void Delete(Book obj)
        {
            booklist.Remove(obj);
        }

        public ICollection<Book> Read()
        {
            return booklist;
        }

        public void Update(Book obj)
        {
            throw new NotImplementedException();
        }
    }
}
