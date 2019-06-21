using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    class Queue<T> : IQueue<T>
    {
        private readonly T[] _myQueue;
        private int _firstInQueue = 0;
        private int _lastInQueue = -1;

        public Queue(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Queue can't be empty, plase fill up size > 0");
            }
            _myQueue = new T[size];
        }
        public void Enqueue(T elem)
        {
            if (_lastInQueue < _myQueue.Length - 1)
            {
                _myQueue[++_lastInQueue] = elem;
            }
            else if (_firstInQueue == 0)
            {
                throw new IndexOutOfRangeException("Queue is full");
            }
            else
            {
                Rebuilding();
                _myQueue[++_lastInQueue] = elem;
            }
        }

        public T Dequeue()
        {
            if (_firstInQueue != _lastInQueue)
            {
                return _myQueue[_firstInQueue++];
            }
            else
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }
        }

        private void Rebuilding()
        {
            for (int i = --_firstInQueue; i < _lastInQueue; i++)
            {
                _myQueue[i] = _myQueue[i + 1];
            }
            _lastInQueue--;
        }

        public T Peek()
        {
            if (_firstInQueue != _lastInQueue)
            {
                return _myQueue[_firstInQueue];
            }
            else
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= _lastInQueue; i++)
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
