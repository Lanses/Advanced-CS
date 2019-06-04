using System;
using System.Collections;
using System.Collections.Generic;

namespace Matrix
{
    abstract class Matrix<T>  : IMatrix<T>
    {
        //H/W   Stack(Plates)   Queue    HashSet


        public int n = int.Parse(Console.ReadLine());
        public int a = int.Parse(Console.ReadLine());
        public int b = int.Parse(Console.ReadLine());

        public Matrix(int n)
        {
            int[,] myMatrix = new int[n, n];
        }



        public int ExtendRankOfTheMatrix { set => throw new NotImplementedException(); }
        int IMatrix<T>.MatrixAddNumberOfRows { set => throw new NotImplementedException(); }
        int IMatrix<T>.MatrixAddNumberOfColumns { set => throw new NotImplementedException(); }

        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
