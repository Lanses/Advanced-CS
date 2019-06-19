using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSet
{
    class HashSet<T> : IHashSet<T>
    {

        private readonly T[] _myHashSet;
        private int n = 5;

        public void Add(T obj)
        {
            _myHashSet[0] = obj;
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        T IHashSet<T>.GetHashCode()
        {
            return _myHashSet[n];
        }
    }
}
