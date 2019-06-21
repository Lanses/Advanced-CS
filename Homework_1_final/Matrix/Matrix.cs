
using System;
using System.Collections;
using System.Collections.Generic;

namespace Matrix
{
    class Matrix<T> : IMatrix<T>
    {

        private readonly T[,,] _myMatrix;
        private readonly int _length;

        public Matrix(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be > 0");
            }

            _length = n;
            _length = n;
            _myMatrix = new T[n, n, n];
        }

        public void Insert(int i, int j, int k, T elem)
        {
            if (i < 0 || j < 0 || k < 0 || i > _length - 1 || j > _length - 1 || k > _length - 1)
            {
                return;
            }
            _myMatrix[i, j, k] = elem;
        }

        public T GetByIndex(int i, int j, int k)
        {
            if (i < 0 || j < 0 || k < 0 || i > _length - 1 || j > _length - 1 || k > _length - 1)
            {
                return default;
            }
            return _myMatrix[i, j, k];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _length; j++)
                {
                    for (int k = 0; j < _length; j++)
                    {
                        yield return _myMatrix[i, j, k];
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
