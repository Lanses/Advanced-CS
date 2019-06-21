using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    class Stack<T> : IStack<T>
    {

        private readonly T[] _myStack;
        private int _position = -1;

        public Stack(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Stack can't be empty, plase fill up size > 0");
            }
            _myStack = new T[size];
        }

        public void Push(T elem)
        {
            if (_position + 1 < _myStack.Length)
            {
                _myStack[++_position] = elem;
            }
            else
            {
                throw new IndexOutOfRangeException("Stack is full");
            }
        }

        public T Pop()
        {
            if (_position >= 0)
            {
                var tmp = _myStack[_position--];
                _myStack[_position + 1] = default;
                return tmp;
            }
            else
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
        }

        public T Peek()
        {
            if (_position >= 0)
            {
                return _myStack[_position];
            }
            else
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= _position; i++)
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
