using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> items;
        private int index;

        public ListyIterator(List<T> items)
        {
            this.items = items;
            this.index = 0;
        }

        //for the test
        public ListyIterator(params T[] items)
        {
            this.items = items.ToList();
            this.index = 0;
        }

        public bool Move()
        {
            if (HasNext()==true)
            {
                this.index++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (items.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(this.items[this.index]);
        }

        public bool HasNext()
        {
            return this.index < this.items.Count - 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in items)
            {
                yield return item;
            }
            //for (int i = 0; i < items.Count; i++)
            //{
            //    yield return items[i];

            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
