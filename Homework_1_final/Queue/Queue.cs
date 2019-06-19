using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue<T> : IQueue<T>
    {
        private readonly T[] _myQueue;

        public T Dequeue()
        {
            return _myQueue[0];
        }

        public void Enqueue(T obj)
        {
            _myQueue[0] = obj;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            return _myQueue[0];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
