using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    class Stack<T> : IStack<T>
    {
        
        private readonly T[] _myStack;
        private int _place = int.Parse(Console.ReadLine());
        private int _popNumber = int.Parse(Console.ReadLine());

        public Stack(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be > 0");
            }
            _myStack = new T[n];
        }


        public T Peek()
        {
            return _myStack[_place];
        }

        public T Pop()
        {
            var popNmbr = _myStack[_popNumber];

            return popNmbr;
        }

        public void Push(T obj)
        {
            if (_place + 1 < _myStack.Length)
            {
                _myStack[_place] = obj;
            }
            else
            {
                throw new IndexOutOfRangeException("Please fill up less number of place. Stack is smaller");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= _place; i++)
            {
                yield return _myStack[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
