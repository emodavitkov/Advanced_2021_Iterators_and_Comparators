﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    class Book
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Authors = new List<string>(authors);
            Title = title;
            Year = year;
        }
    }
}
