using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    internal class LibraryIterator : IEnumerator<Book>
    {
        private SortedSet<Book> books;

        private int currentIndex = -1;

        public LibraryIterator(SortedSet<Book> books)
        {
            Reset();
            this.books = new SortedSet<Book>(books);
        }

        public Book Current => books.ToList()[currentIndex];

        object IEnumerator.Current => this.Current;

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