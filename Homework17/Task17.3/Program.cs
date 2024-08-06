using System.Collections;

namespace Task17._3
{
    // Library Bookshelf:
    internal class Program
    {
        static void Main(string[] args)
        {
            Library books = new Library();
            Polka books1 = new Polka();
            books1.AddBook(new Book("Anna Karenina"));
            books1.AddBook(new Book("Agata Kristi"));
            foreach(var book in books1)
            {
                Console.WriteLine(book);
            }
        }
    }
    class Book
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }

    }
    class Polka : IEnumerable<Book> 
    {
        public List<Book> books = new List<Book>();
      
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public IEnumerator<Book> GetEnumerator() 
        {
            return books.GetEnumerator(); 
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Library : IEnumerable<Book> 
    {
        
        public List<Polka> polka = new List<Polka>();

        public void AddPolka(Polka polka)
        {
           this.polka.Add(polka);   
        }
        public IEnumerator<Polka> GetEnumerator()
        { 
            return polka.GetEnumerator(); 
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    
}
