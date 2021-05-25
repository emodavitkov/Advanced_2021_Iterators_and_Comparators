﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    class Library : IEnumerable<Book>
    {
        readonly List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);

        }

        public IEnumerator<Book> GetEnumerator()
        {

            return new LibraryIterator(books);
            //for (int i = 0; i < books.Count; i++)
            //{
            //    yield return books[i];

            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }
}
