using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    class Queue<T> : IQueue<T>
    {
        private readonly T[] _myQueue;
        private int _place = int.Parse(Console.ReadLine());
        private int _dequeueNumber = int.Parse(Console.ReadLine());

        public Queue(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be > 0");
            }
            _myQueue = new T[n];
        }


        public T Dequeue()
        {
            var dqNmbr = _myQueue[_dequeueNumber];

            return dqNmbr;
        }

        public void Enqueue(T obj)
        {
            if (_place + 1 < _myQueue.Length)
            {
                _myQueue[_place] = obj;
            }
            else
            {
                throw new IndexOutOfRangeException("Please fill up less number of place. Stack is smaller");
            }
        }


        public T Peek()
        {
            return _myQueue[_place];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= _place; i++)
            {
                yield return _myQueue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
