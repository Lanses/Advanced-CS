using System.Collections.Generic;


namespace HashSet
{
    interface IHashSet<T> : IEnumerable<T>
    {

        void Add(T obj);

        T GetHashCode();
    }
}
