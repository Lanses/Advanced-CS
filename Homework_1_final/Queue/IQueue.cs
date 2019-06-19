using System.Collections.Generic;


namespace Queue
{
    interface IQueue<T> : IEnumerable<T>
    {
        void Enqueue(T obj);
        T Dequeue();
    }
}
