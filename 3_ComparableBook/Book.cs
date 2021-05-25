using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
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

        public int CompareTo(Book other)
        {
            if (Year != other.Year)
            {
                return Year - other.Year;
            }

            return Title.CompareTo(other.Title);

            //int result = this.Year.CompareTo(other.Year);
            //if (result==0)
            //{
            //    result = this.Title.CompareTo(other.Title);
            //}
            //return result;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}"; 
        }
    }
}
