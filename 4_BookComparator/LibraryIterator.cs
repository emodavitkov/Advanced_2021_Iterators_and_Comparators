using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    internal class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;

        private int currentIndex = -1;

        public LibraryIterator(List<Book> books)
        {
            Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => books.ToList()[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            currentIndex++;
            return currentIndex < books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

       
    }
}