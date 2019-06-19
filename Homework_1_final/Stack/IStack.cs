using System.Collections.Generic;

namespace Stack
{
    interface Stack<T> : IEnumerable<T>
    {
        void Push(T elem);
        T Pop();
        T Peek();
    }
}
