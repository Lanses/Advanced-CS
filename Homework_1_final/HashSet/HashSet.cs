    using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSet
{
    class HashSet<T> : IHashSet<T>
    {

        private readonly T[] _myHashSet;
        private int _position = -1;

        public HashSet(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("HashSet can't be empty, plase fill up size > 0");
            }
            _myHashSet = new T[size];
        }

        public void Add(T elem)
        {
            foreach (var item in this)
            {
                if (item.Equals(elem))
                {
                    throw new ArgumentException("This element is already in the collection");
                }
            }
            if (_position + 1 < _myHashSet.Length)
            {
                _myHashSet[++_position] = elem;
            }
            else
            {
                throw new IndexOutOfRangeException("HashSet is full");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= _position; i++)
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
            return _myHashSet[_position];
        }
    }
}
