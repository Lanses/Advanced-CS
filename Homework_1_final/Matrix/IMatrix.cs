using System.Collections.Generic;


namespace Matrix
{
    interface IMatrix<T> : IEnumerable<T>
    {

        void Insert(int i, int j, int k, T obj);


    }
}
