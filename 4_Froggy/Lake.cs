using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy 
{
    public class Lake : IEnumerable<int>
    {

        private readonly List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }
        //13, 23, 1,-8 ,4,9
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i+=2)
            {
                yield return this.stones[i];
            }

            //wrong but just as an example
            ////int index = this.stones.Count - 1 % 2 != 0 ?
            ////    this.stones.Count - 2 :
            ////    this.stones.Count - 1;

            for (int i = stones.Count -1 -(stones.Count%2); i >= 0; i-=2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
