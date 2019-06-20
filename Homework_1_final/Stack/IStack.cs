using System.Collections.Generic;

namespace Stack
{
    interface IStack<T> : IEnumerable<T>
    {
        void Push(T elem);
        T Pop();
        T Peek();
    }
}
