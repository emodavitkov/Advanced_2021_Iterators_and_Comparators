using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        readonly List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            BookComparator bookComparator = new BookComparator();

            this.books.Sort(bookComparator);

        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    
    }
}
