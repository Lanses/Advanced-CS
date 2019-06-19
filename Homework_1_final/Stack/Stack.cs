using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack<T> : IStack<T>
    {

        private readonly T[] _myStack;

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            return _myStack[0];
        }

        public T Pop()
        {
            return _myStack[0];
        }

        public void Push(T obj)
        {
            _myStack[0] = obj;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
