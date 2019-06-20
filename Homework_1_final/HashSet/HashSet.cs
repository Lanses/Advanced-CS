    using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSet
{
    class HashSet<T> : IHashSet<T>
    {

        private readonly T[] _myHashSet;
        private int _place = int.Parse(Console.ReadLine());
        private int _hashCodeNumber = int.Parse(Console.ReadLine());

        public HashSet(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be > 0");
            }
            _myHashSet = new T[n];
        }

        public void Add(T obj)
        {
            if (_place + 1 < _myHashSet.Length)
            {
                _myHashSet[_place] = obj;
            }
            else
            {
                throw new IndexOutOfRangeException("Please fill up less number of place. HashSet is smaller");
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= _place; i++)
            {
                yield return _myHashSet[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        T IHashSet<T>.GetHashCode()
        {
            return _myHashSet[_hashCodeNumber];
        }
    }
}
