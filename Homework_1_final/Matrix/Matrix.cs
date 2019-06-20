
using System;
using System.Collections;
using System.Collections.Generic;

namespace Matrix
{
    class Matrix<T> : IMatrix<T>
    {

        private readonly T[,,] _myMatrix;
        private int _squareMatrixFirstIndex;
        private int _squareMatrixSecondIndex;

        public Matrix(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be > 0");
            }

            _squareMatrixFirstIndex = n;
            _squareMatrixSecondIndex = n;
            _myMatrix = new T[_squareMatrixFirstIndex,_squareMatrixSecondIndex, n];
        }

        public T GetByIndex(int i, int j, int k)
        {
            return _myMatrix[i, j, k];
        }


        public void Insert(int i, int j, int k, T obj)
        {
            _myMatrix[i, j, k] = obj;
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _squareMatrixFirstIndex; i++)
            {
                for (int j = 0; j < _squareMatrixFirstIndex; j++)
                {
                    for(int k = 0; j < _squareMatrixFirstIndex; j++)
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
