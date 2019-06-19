

using System.Collections;
using System.Collections.Generic;

namespace Matrix
{
    class Matrix<T> : IMatrix<T>
    {

        private readonly T[,,] _myMatrix;

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int i, int j, int k, T obj)
        {
            _myMatrix[i, j, k] = obj;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
